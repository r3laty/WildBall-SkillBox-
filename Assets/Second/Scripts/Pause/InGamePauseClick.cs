using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePauseClick : MonoBehaviour
{
    public void OnPauseCLick()
    {
        Time.timeScale = 0;        
    }

    public void OnContinueClick()
    {
        Time.timeScale = 1;
    }
}
