using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    [SerializeField] private Transform target = null;
    [SerializeField] private Vector3 offset = Vector3.zero;
    [SerializeField] private float followSpeed = 10f;
    [SerializeField] private float lookSpeed = 10f;



    // Start is called before the first frame update
    private void FixedUpdate() {
        LookAtTarget();
        MoveToTarget();
    }
    void LookAtTarget() {
        Vector3 lookDirection = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);
    }
    void MoveToTarget() {
        Vector3 targetPos = target.position +
                            target.forward * offset.z +
                            target.right * offset.x +
                            target.up * offset.y;
        transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);
    }
}
