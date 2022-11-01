using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Controls Controls;
    private const string LevelIndexKey = "LevelIndex";

    public Restart Restart;
    public NextLevel NextLevel;

    public Dissolve Dissolve;

    public Sounds Sounds;

    public LossParticleSystem LossParticleSystem;   
    public WonParticleSystem WonParticleSystem; 

     public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

   public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Dissolve.Gone();
        Sounds.PlaySound();
        LossParticleSystem.LossPS();
        Controls.enabled = false;
        Debug.Log("Game Over!");
        Restart.Setup();

    }
    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        WonParticleSystem.WonPS();
        Controls.enabled = false;
        LevelIndex++;
        Debug.Log("You Won!");
        NextLevel.Setup();  
       
    }
    
    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set 
        { PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }
  
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevelScene()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
