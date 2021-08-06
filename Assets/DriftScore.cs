using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DriftScore : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float angleVelocityOffset;
    private Vector3 velocity;
    private Vector3 forward;
    public float DriftPoints { get; set; }

    private Car car;
    private float carSpeed;
    private bool isDrifting;
    private bool hasCollided;

    private float driftTimer;

    [SerializeField] private TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Car>();
        hasCollided = false;
        _rigidbody = GetComponent<Rigidbody>();
        driftTimer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        carSpeed = car.CarSpeed;
        forward = transform.forward;
        velocity = _rigidbody.velocity;
        angleVelocityOffset = Vector3.Angle(forward, velocity);

        if(carSpeed > 25 && angleVelocityOffset > 15 && !hasCollided) {
            isDrifting = true;
        } else { 
            isDrifting = false;
        }

        if (isDrifting) {
            driftTimer += Time.deltaTime;
            DriftPoints += driftTimer * angleVelocityOffset / 100;
        } else { driftTimer = 1; }

        score.text = DriftPoints.ToString("F0");
    }
    private void OnCollisionEnter(Collision collision) {
        hasCollided = true;
    }
    private void OnCollisionExit(Collision collision) {
        hasCollided = false;
    }
}
