using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    [SerializeField]
    private Camera _camera = null;
    private Canvas canvas = null;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        canvas.transform.rotation = _camera.transform.rotation;
    }
}
