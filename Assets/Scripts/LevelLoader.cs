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

    [SerializeField]
    private GameObject level;

    [SerializeField]
    private GameObject answewrCanvas;

    [SerializeField]
    private GameObject trueEmoji;

    [SerializeField]
    private GameObject falseEmoji;

    private void Start()
    {
        randomSceneEasy = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        randomSceneMedium = new List<int> { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };
        randomSceneHard = new List<int> { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };
    }

    public void LoadNextLevel()
    {

        if (isEasy && PermUI.perm.level >= 5)
        {
            PermUI.perm.victory.GetComponent<CanvasGroup>().alpha = 1;

            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].rb.gravityScale = Random.Range(-1f, -0.2f);
            }

            isEasy = false;
        }
        if (isEasy && PermUI.perm.level < 20)
        {
            PermUI.perm.level++;
            PermUI.perm.combatTextLevelPlus.SetActive(true);
            PermUI.perm.combatTextLevelPlus.GetComponent<Animator>().SetTrigger("hit");
            StartCoroutine(LoadLevelEasyTimer());
        }
        if (isEasy && PermUI.perm.level >= 20)
        {
            isEasy = false;
            isMedium = true;
            isHard = false;
            StartCoroutine(LoadLevelMediumTimer());
        }
        if (isMedium && PermUI.perm.level < 40)
        {
            PermUI.perm.level++;
            PermUI.perm.combatTextLevelPlus.SetActive(true);
            PermUI.perm.combatTextLevelPlus.GetComponent<Animator>().SetTrigger("hit");
            StartCoroutine(LoadLevelMediumTimer());
        }
        if (isMedium && PermUI.perm.level >= 40)
        {
            isEasy = false;
            isMedium = false;
            isHard = true;
            StartCoroutine(LoadLevelHardTimer());
        }
        if (isHard && PermUI.perm.level < 60)
        {
            PermUI.perm.level++;
            PermUI.perm.combatTextScoreMinus.SetActive(true);
            PermUI.perm.combatTextScoreMinus.GetComponent<Animator>().SetTrigger("hit");
            StartCoroutine(LoadLevelHardTimer());
        }
        if (isHard && PermUI.perm.level >= 60)
        {
            PermUI.perm.victory.SetActive(true);
            isHard = false;
        }
    }

    public void LoadLevelEasy()
    {
        PermUI.perm.level = 0;
        PermUI.perm.score = 100;
        PermUI.perm.answerCanvas.SetActive(true);
        isEasy = true;
        isMedium = false;
        isHard = false;
        StartCoroutine(LoadLevelEasyTimer());
    }

    public void LoadLevelMedium()
    {
        PermUI.perm.level = 20;
        PermUI.perm.score = 100;
        isEasy = false;
        isMedium = true;
        isHard = false;
        StartCoroutine(LoadLevelMediumTimer());
    }

    public void LoadLevelHard()
    {
        PermUI.perm.level = 40;
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

        yield return new WaitForSeconds(1f);
        PermUI.perm.combatTextScorePlus.SetActive(false);//
        PermUI.perm.combatTextScoreMinus.SetActive(false);//
        PermUI.perm.combatTextLevelPlus.SetActive(false);
        level.SetActive(true);
        score.SetActive(true);
        PermUI.perm.advertiser.SetActive(true);
        PermUI.perm.trueEmoji.SetActive(false);
        PermUI.perm.answerCanvas.SetActive(false);
        PermUI.perm.backStorImagesCanvas.SetActive(true);
        PermUI.perm.frontStoreImagesCanvas.SetActive(true);
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
        level.SetActive(true);
        score.SetActive(true);
        PermUI.perm.advertiser.SetActive(true);

        PermUI.perm.trueEmoji.SetActive(false);
        PermUI.perm.answerCanvas.SetActive(false);
        PermUI.perm.backStorImagesCanvas.SetActive(true);
        PermUI.perm.frontStoreImagesCanvas.SetActive(true);
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
        level.SetActive(true);
        score.SetActive(true);
        PermUI.perm.advertiser.SetActive(true);

        PermUI.perm.trueEmoji.SetActive(false);
        PermUI.perm.answerCanvas.SetActive(false);
        PermUI.perm.backStorImagesCanvas.SetActive(true);
        PermUI.perm.frontStoreImagesCanvas.SetActive(true);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("1 START MENU");
        PermUI.perm.victory.GetComponent<CanvasGroup>().alpha = 0;
        for (int i = 0; i < PermUI.perm.ballons.Length; i++)
        {
            PermUI.perm.ballons[i].rb.gravityScale = 2;
            PermUI.perm.ballons[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }

        PermUI.perm.trueEmoji.SetActive(false);
        PermUI.perm.backStorImagesCanvas.SetActive(true);
        PermUI.perm.frontStoreImagesCanvas.SetActive(true);
        level.SetActive(false);
        score.SetActive(false);
        PermUI.perm.level = 0;
        PermUI.perm.score = 0;
    }
}