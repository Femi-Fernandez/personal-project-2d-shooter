using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public bool GameOver = false;
    // Use this for initialization
    void Start () {
		
	}
    private void OnGUI()
    {
        if (GameOver)
        {
            GUILayout.Label("GAME OVER: press Enter to restart the stage");
        }

    }
    // Update is called once per frame
    void Update () {
        if (GameOver)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("Scene_1");
            }
        }
	}
}
