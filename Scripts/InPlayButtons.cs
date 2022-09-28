using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InPlayButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void Reshuffle()
    {
        GameObject.Find("Main Camera").GetComponent<GameScript>().Shuffle(); 
        //SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
