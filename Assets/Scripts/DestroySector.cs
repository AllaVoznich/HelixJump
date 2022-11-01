using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySector : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void DestroyPS()
    {
        particleSystem.Play();
    }
}
