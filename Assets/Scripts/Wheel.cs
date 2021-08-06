using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] private bool steer = false;
    [SerializeField] private bool invertSteer = false;
    [SerializeField]private bool power;
    public bool ShouldBurnOut { get; set; }

    public bool Power {
        get { return power; }
        set { power = false; }
    }


    public float SteerAngle { get; set; }
    public float Torque { get; set; }

    public WheelCollider WheelCollider { get; set; }
    private Transform wheelTransform;

    // Start is called before the first frame update
    void Start()
    {
        WheelCollider = GetComponentInChildren<WheelCollider>();
        wheelTransform = GetComponentInChildren<MeshRenderer>().GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        WheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
    }

    private void FixedUpdate() {
        if (steer) {
            WheelCollider.steerAngle = SteerAngle * (invertSteer ? -1 : 1);
        }
        if (power) {
            WheelCollider.motorTorque = Torque;
        }
    }
}
