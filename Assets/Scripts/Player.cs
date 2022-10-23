using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;
   
    public SoundManager SoundManager;   

    public Platform CurrentPlatform;
    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
        SoundManager.PlayBounceSound();
    }

    public void Die()
    {
        Game.OnPlayerDied();
    }

    public void ReachedFinish()
    {
        Game.OnPlayerReachedFinish();
    }
}
