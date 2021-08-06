using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireSmoke : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] smokeParticles = null;
    [SerializeField] private WheelSkid[] wheelSkids = null;
    [SerializeField] private Wheel[] wheels = null;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update() {
        //for (int i = 0; i < wheelSkids.Length; i++) {
        //    if (wheelSkids[i].IsSkidding) {
        //        if (!smokeParticles[i].isPlaying) {
        //            smokeParticles[i].Play();
        //        } else {
        //            if (smokeParticles[i].isPlaying) {
        //                smokeParticles[i].Stop();
        //            }
        //        }
        //    }

        //}
        if (wheelSkids[0].IsSkidding || wheels[0].ShouldBurnOut) {
            if (!smokeParticles[0].isPlaying)
                smokeParticles[0].Play();
        } else {
            if (smokeParticles[0].isPlaying) {
                smokeParticles[0].Stop();
            }
        }

        if (wheelSkids[1].IsSkidding || wheels[1].ShouldBurnOut) {
            if (!smokeParticles[1].isPlaying)
                smokeParticles[1].Play();
        } else {
            if (smokeParticles[1].isPlaying) {
                smokeParticles[1].Stop();
            }
        }

        if (wheelSkids[2].IsSkidding || wheels[2].ShouldBurnOut) {
            if (!smokeParticles[2].isPlaying)
                smokeParticles[2].Play();
        } else {
            if (smokeParticles[2].isPlaying) {
                smokeParticles[2].Stop();
            }
        }
        if (wheelSkids[3].IsSkidding || wheels[3].ShouldBurnOut) {
            if (!smokeParticles[3].isPlaying)
                smokeParticles[3].Play();
        } else {
            if (smokeParticles[3].isPlaying) {
                smokeParticles[3].Stop();
            }
        }
    }
}
