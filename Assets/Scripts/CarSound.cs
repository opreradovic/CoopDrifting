using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSound : MonoBehaviour
{
    private float topSpeed = 200;
    private float currentSpeed = 0;
    private float pitch = 0;

    private AudioSource audioSource;
    private Car car;

    [SerializeField]
    private WheelSkid[] wheelSkids;
    [SerializeField]
    private AudioSource[] skidSounds;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Car>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = car.CarSpeed;
        pitch = currentSpeed / topSpeed;


        audioSource.pitch = 0.4f + pitch;

        print(audioSource.pitch);

        for (int i = 0; i < wheelSkids.Length; i++) {
            if (wheelSkids[i].IsSkidding) {
                if(!skidSounds[i].isPlaying)
                    skidSounds[i].Play();
            }else if (!wheelSkids[i].IsSkidding) {
                skidSounds[i].Stop();
            }
        }
    }
}
