using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void play()
    {
        SceneManager.LoadScene("PracticeScene");
    }

    public static void GoToTitleScreen()
    {
        SceneManager.LoadScene("TitleMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void titleScreen()
    {
        SceneManager.LoadScene("TitleMenu");
    }
}
