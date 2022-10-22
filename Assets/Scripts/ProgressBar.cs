using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    
    public Player Player;
    public Transform Finish;
    public Slider Slider;

    private float _startPos;
    private float _minimumReachedPos;

    private void Start()
    {
        _startPos = Player.transform.position.y;
    }


    private void Update()
    {
        _minimumReachedPos = Mathf.Min(_minimumReachedPos, Player.transform.position.y);
       // float currentPos = Player.transform.position.y;
        float finishPos = Finish.transform.position.y;
        float Value = Mathf.InverseLerp(_startPos, finishPos + 1.0f, _minimumReachedPos);
        Slider.value = Value;
    }
}
