using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameStarted;

	void Start ()
    {
        isGameStarted = false;
    }
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
	}

    private void StartGame()
    {
        isGameStarted = true;
    }

    internal void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
