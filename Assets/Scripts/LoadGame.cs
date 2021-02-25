using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    //private LevelLoader ll;

    private void Start()
    {
        //ll = FindObjectOfType<LevelLoader>();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("1 START MENU");
        //ll.LoadMainMenu();
    }
}