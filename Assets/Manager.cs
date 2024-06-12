using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI onFocusText;
    [SerializeField] private TextMeshProUGUI onPauseText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        onFocusText.text = $"OnFocus {hasFocus}";
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        onPauseText.text = $"OnPause {pauseStatus}";
    }
}
