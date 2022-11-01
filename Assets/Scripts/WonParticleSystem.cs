using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonParticleSystem : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void WonPS()
    {
        particleSystem.Play();
    }
}
