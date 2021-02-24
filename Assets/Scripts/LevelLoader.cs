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

    public bool is1thru5 = false;
    public bool is6thru10 = false;
    public bool is11thru15 = false;
    public bool is16thru20 = false;

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
        BackGroundPlayer.backGroundPlayer.screenStartButton.SetActive(true);
        is1thru5 = true;

        randomSceneEasy = new List<int> 
        { 
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20 
        };
        randomSceneMedium = new List<int> 
        { 
            21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40 
        };
        randomSceneHard = new List<int> 
        { 
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
            51, 52, 53, 54, 55, 56, 57, 58, 59, 60 
        };
    }

    public void LoadNextLevel()
    {
        if (isEasy && PermUI.perm.level < 20)
        {
            PermUI.perm.level++;
            PermUI.perm.combatTextLevelPlus.SetActive(true);
            PermUI.perm.combatTextLevelPlus.GetComponent<Animator>().SetTrigger("hit");

            if (PermUI.perm.level <=5)
            {
                is16thru20 = false;
                is1thru5 = true;
            }
            if (PermUI.perm.level > 5)
            {
                is1thru5 = false;
                is6thru10 = true;
            }
            if (PermUI.perm.level > 10)
            {
                is6thru10 = false;
                is11thru15 = true;
            }
            if (PermUI.perm.level > 15)
            {
                is11thru15 = false;
                is16thru20 = true;
            }

            StartCoroutine(LoadLevelEasyTimer());
        }
        if (isEasy && PermUI.perm.level >= 20)
        {
            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }

            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].rb.gravityScale = Random.Range(-1f, -0.2f);
            }

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

            if (PermUI.perm.level <= 25)
            {
                is16thru20 = false;
                is1thru5 = true;
            }
            if (PermUI.perm.level > 25)
            {
                is1thru5 = false;
                is6thru10 = true;
            }
            if (PermUI.perm.level > 30)
            {
                is6thru10 = false;
                is11thru15 = true;
            }
            if (PermUI.perm.level > 35)
            {
                is11thru15 = false;
                is16thru20 = true;
            }

            StartCoroutine(LoadLevelMediumTimer());
        }
        if (isMedium && PermUI.perm.level >= 40)
        {
            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].rb.gravityScale = Random.Range(-1f, -0.2f);
            }

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

            if (PermUI.perm.level <= 45)
            {
                is16thru20 = false;
                is1thru5 = true;
            }
            if (PermUI.perm.level > 45)
            {
                is1thru5 = false;
                is6thru10 = true;
            }
            if (PermUI.perm.level > 50)
            {
                is6thru10 = false;
                is11thru15 = true;
            }
            if (PermUI.perm.level > 55)
            {
                is11thru15 = false;
                is16thru20 = true;
            }

            StartCoroutine(LoadLevelHardTimer());
        }
        if (isHard && PermUI.perm.level >= 60)
        {
            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].rb.gravityScale = Random.Range(-1f, -0.2f);
            }

            isHard = false;
        }
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

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(currentScene);

        if (is1thru5)
        {
            BackGroundPlayer.backGroundPlayer.screenStartMenu.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen1_5.SetActive(true);
        }
        if (is6thru10)
        {
            BackGroundPlayer.backGroundPlayer.screen1_5.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen6_10.SetActive(true);
        }
        if (is11thru15)
        {
            BackGroundPlayer.backGroundPlayer.screen6_10.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen11_15.SetActive(true);
        }
        if (is16thru20)
        {
            BackGroundPlayer.backGroundPlayer.screen11_15.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen16_20.SetActive(true);
        }
      
        level.SetActive(true);
        score.SetActive(true);

        PermUI.perm.combatTextScorePlus.SetActive(false);
        PermUI.perm.combatTextScoreMinus.SetActive(false);
        PermUI.perm.combatTextLevelPlus.SetActive(false);
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

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(currentScene);

        if (is1thru5)
        {
            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].rb.gravityScale = 2;
                PermUI.perm.ballons[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            }

            BackGroundPlayer.backGroundPlayer.screen16_20.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen1_5.SetActive(true);
        }
        if (is6thru10)
        {
            BackGroundPlayer.backGroundPlayer.screen1_5.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen6_10.SetActive(true);
        }
        if (is11thru15)
        {
            BackGroundPlayer.backGroundPlayer.screen6_10.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen11_15.SetActive(true);
        }
        if (is16thru20)
        {
            BackGroundPlayer.backGroundPlayer.screen11_15.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen16_20.SetActive(true);
        }

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

        yield return new WaitForSeconds(0.3f);

        SceneManager.LoadScene(currentScene);

        if (is1thru5)
        {
            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].rb.gravityScale = 2;
                PermUI.perm.ballons[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            }

            BackGroundPlayer.backGroundPlayer.screen16_20.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen1_5.SetActive(true);
        }
        if (is6thru10)
        {
            BackGroundPlayer.backGroundPlayer.screen1_5.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen6_10.SetActive(true);
        }
        if (is11thru15)
        {
            BackGroundPlayer.backGroundPlayer.screen6_10.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen11_15.SetActive(true);
        }
        if (is16thru20)
        {
            BackGroundPlayer.backGroundPlayer.screen11_15.SetActive(false);
            BackGroundPlayer.backGroundPlayer.screen16_20.SetActive(true);
        }

        level.SetActive(true);
        score.SetActive(true);
        PermUI.perm.advertiser.SetActive(true);

        PermUI.perm.trueEmoji.SetActive(false);
        PermUI.perm.answerCanvas.SetActive(false);
        PermUI.perm.backStorImagesCanvas.SetActive(true);
        PermUI.perm.frontStoreImagesCanvas.SetActive(true);
    }

    public void LoadLevelEasy()
    {
        PermUI.perm.level = 1;
        PermUI.perm.score = 100;
        PermUI.perm.answerCanvas.SetActive(true);

        isEasy = true;
        isMedium = false;
        isHard = false;
        StartCoroutine(LoadLevelEasyTimer());
    }

    public void LoadLevelMedium()
    {
        PermUI.perm.level = 21;
        PermUI.perm.score = 100;
        PermUI.perm.answerCanvas.SetActive(true);

        isEasy = false;
        isMedium = true;
        isHard = false;
        StartCoroutine(LoadLevelMediumTimer());
    }

    public void LoadLevelHard()
    {
        PermUI.perm.level = 41;
        PermUI.perm.score = 100;
        PermUI.perm.answerCanvas.SetActive(true);

        isEasy = false;
        isMedium = false;
        isHard = true;
        StartCoroutine(LoadLevelHardTimer());
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("1 START MENU");
        BackGroundPlayer.backGroundPlayer.screenStartButton.SetActive(false);
        BackGroundPlayer.backGroundPlayer.screenStartMenu.SetActive(true);
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
        PermUI.perm.level = 1;
        PermUI.perm.score = 0;
    }
}