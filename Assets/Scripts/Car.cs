using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Car : MonoBehaviour
{
    [SerializeField] private Transform centerOfMass = null;
    [SerializeField] private float motorTorque = 100f;
    [SerializeField] private float brakeTorque = 300f;
    [SerializeField] private float maxSteer = 20f;
    [SerializeField] private TextMeshProUGUI speed = null;
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private GameObject cameraPivot = null;
    [SerializeField] private float topSpeed = 200f;

    //private float driftValue;
    //private float driftAngle;

    private Rigidbody _rigidbody = null;
    private Wheel[] wheels = null;
    private bool doBurnout = false;
    private Vector3 cameraMoveVector = Vector3.zero;


    public bool DoBurnout {
        get { return doBurnout; }
        set { doBurnout = false; }
    }

    public float AngleVelocityOffset { get; private set; }
    public float CarSpeed { get; private set; }
    public float Steer { get; set; }
    public float Throttle { get; set; }
    public float MinusThrottle { get; set; }
    public int Brake { get; set; }
    public bool IsBraking { get; set; }

    public bool IsVisible { get; set; }

    public Transform SpawnPosition { get; set; }

    // Start is called before the first frame update
    private void Start() {
        wheels = GetComponentsInChildren<Wheel>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centerOfMass.localPosition;
    }
    private void Update() {
        cameraPivot.transform.position = transform.position;

        CarSpeed = _rigidbody.velocity.magnitude * 3.6f;

        speed.text = CarSpeed.ToString("F0");
        if (doBurnout) { Burnout(); }
        if (!doBurnout) { CancelBurnout(); }

        if (GameManager.Instance.GameStarted) {
            foreach (var wheel in wheels) {
                HandleCar(wheel);
            }
        }

        MoveCamera();
    }
    private void FixedUpdate() {
        _rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, topSpeed);
    }

    public void ResetCar() {
        _rigidbody.velocity = Vector3.zero;
        foreach(var wheel in wheels) {
            wheel.Torque = 0;
            wheel.WheelCollider.brakeTorque = 0;
        }
        transform.position = SpawnPosition.position;
        transform.rotation = SpawnPosition.rotation;
        _rigidbody.velocity = Vector3.zero;
    }
    void HandleCar(Wheel wheel) {
        wheel.SteerAngle = Steer * maxSteer;
        if(CarSpeed > topSpeed) {
            wheel.Torque = 0;
        } else {
            if (Throttle != 0 && MinusThrottle != 0 && CarSpeed < 2) {
                doBurnout = true;
            } else if (Throttle != 0 && MinusThrottle != 0 && CarSpeed > 2) {
                wheel.Torque = -MinusThrottle * motorTorque;
            } else if (Throttle != 0) {
                wheel.Torque = Throttle * motorTorque;
                doBurnout = false;
            } else if (MinusThrottle != 0) {
                wheel.Torque = -MinusThrottle * motorTorque;
                doBurnout = false;
            } else {
                wheel.Torque = 0;
                doBurnout = false;
            }
        }

        if (wheel.WheelCollider != null) {
            if (Brake > 0) {
                wheel.WheelCollider.brakeTorque = brakeTorque;
                IsBraking = true;
            } else{
                wheel.WheelCollider.brakeTorque = 0;
                IsBraking = false;
            }
        }
    }
    void Burnout() {
        if (doBurnout) {
            _rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            foreach(var wheel in wheels) {
                if (wheel.Power) {
                    wheel.Torque = motorTorque;
                    wheel.ShouldBurnOut = true;
                }
            }
        }
    }
    void CancelBurnout() {
        _rigidbody.constraints = RigidbodyConstraints.None;
        foreach (var wheel in wheels) {
            if (wheel.Power) {
                wheel.ShouldBurnOut = false;
            }
        }
    }
    public void MoveCamera(Vector2 move) {
        cameraMoveVector = new Vector3(0, move.x, 0);
    }
    void MoveCamera() {

        if (cameraMoveVector.y != 0) {
            cameraPivot.GetComponentInChildren<CameraFollow>().enabled = false;
            cameraPivot.transform.eulerAngles = cameraPivot.transform.eulerAngles - cameraMoveVector;
        }else if(cameraMoveVector.y == 0) {
            cameraPivot.GetComponentInChildren<CameraFollow>().enabled = true;
        }
    }
}

