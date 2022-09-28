using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject text;
    // Start is called before the first frame update
    public void PlayGame()
    {
        Time.timeScale = 1;
        text.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        text.SetActive(true);
    } 
}
