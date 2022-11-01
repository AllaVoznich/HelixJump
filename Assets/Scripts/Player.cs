using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;

    public Platform CurrentPlatform;

    public Sounds Sounds;

//    public DestroySector DestroySector;

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
        Sounds.PlayBounceSound();
  //      DestroySector.DestroyPS();
     
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
