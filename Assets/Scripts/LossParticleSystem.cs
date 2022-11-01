using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossParticleSystem : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void LossPS()
    {
        particleSystem.Play();
    }
}
