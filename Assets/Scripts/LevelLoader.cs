using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    private List<int> randomSceneEasy;
    private List<int> randomSceneMedium;
    private List<int> randomSceneHard;

    public bool isEasy;
    public bool isMedium;
    public bool isHard;

    public float transitionTime = 1f;

    [SerializeField]
    private GameObject score;

    //[SerializeField]
    //private GameObject level;

    //public int level;

    private void Start()
    {
        randomSceneEasy = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        randomSceneMedium = new List<int> { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };
        randomSceneHard = new List<int> { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };
    }

    public void LoadNextLevel()
    {
        if (isEasy && PermUI.perm.level < 20)
        {
            PermUI.perm.level++;
            StartCoroutine(LoadLevelEasyTimer());
        }
        else if (isEasy && PermUI.perm.level >= 20)
        {
            isEasy = false;
            isMedium = true;
            isHard = false;
            StartCoroutine(LoadLevelMediumTimer());
        }

        if (isMedium && PermUI.perm.level < 40)
        {
            PermUI.perm.level++;
            StartCoroutine(LoadLevelMediumTimer());
        }
        else if (isMedium && PermUI.perm.level >= 40)
        {
            isEasy = false;
            isMedium = false;
            isHard = true;
            StartCoroutine(LoadLevelHardTimer());
        }

        if (isHard && PermUI.perm.level < 60)
        {
            PermUI.perm.level++;
            StartCoroutine(LoadLevelHardTimer());
        }
        else if (isHard && PermUI.perm.level >= 60)
        {
            PermUI.perm.victory.SetActive(true);


            isHard = false;
        }
    }

    public void LoadLevelEasy()
    {
        PermUI.perm.level = 1;
        PermUI.perm.score = 100;
        isEasy = true;
        isMedium = false;
        isHard = false;
        StartCoroutine(LoadLevelEasyTimer());
    }

    public void LoadLevelMedium()
    {
        PermUI.perm.level = 21;
        PermUI.perm.score = 100;
        isEasy = false;
        isMedium = true;
        isHard = false;
        StartCoroutine(LoadLevelMediumTimer());
    }

    public void LoadLevelHard()
    {
        PermUI.perm.level = 41;
        PermUI.perm.score = 100;
        isEasy = false;
        isMedium = false;
        isHard = true;
        StartCoroutine(LoadLevelHardTimer());
    }

    private IEnumerator LoadLevelEasyTimer()
    {
        yield return new WaitForSeconds(transitionTime);
        
        if (randomSceneEasy.Count == 0)
        {
            yield break;
        }

        int randomIndex = Random.Range(0, randomSceneEasy.Count);
        int currentScene = randomSceneEasy[randomIndex];
        randomSceneEasy.RemoveAt(randomIndex);
        SceneManager.LoadScene(currentScene);

        yield return new WaitForSeconds(0.3f);
        score.SetActive(true);
    }

    private IEnumerator LoadLevelMediumTimer()
    {
        yield return new WaitForSeconds(transitionTime);

        if (randomSceneMedium.Count == 0)
        {
            yield break;
        }

        int randomIndex = Random.Range(0, randomSceneMedium.Count);
        int currentScene = randomSceneMedium[randomIndex];
        randomSceneMedium.RemoveAt(randomIndex);
        SceneManager.LoadScene(currentScene);

        yield return new WaitForSeconds(0.3f);
        score.SetActive(true);
    }

    private IEnumerator LoadLevelHardTimer()
    {
        yield return new WaitForSeconds(transitionTime);

        if (randomSceneHard.Count == 0)
        {
            yield break;
        }

        int randomIndex = Random.Range(0, randomSceneHard.Count);
        int currentScene = randomSceneHard[randomIndex];
        randomSceneHard.RemoveAt(randomIndex);
        SceneManager.LoadScene(currentScene);

        yield return new WaitForSeconds(0.3f);
        score.SetActive(true);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("1 START MENU");
        PermUI.perm.victory.SetActive(false);
        PermUI.perm.level = 0;
        PermUI.perm.score = 0;
    }
}