using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppPaused : MonoBehaviour
{
    private bool _paused = false;

    public GameObject panel;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnPausedToggle();
        }
    }

    void OnPausedToggle()
    {
        if (!_paused)
        {
            Time.timeScale = 0;
            _paused = true;
            panel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            _paused = false;
            panel.SetActive(false);
        }
    }
}