using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PermUI : MonoBehaviour
{
    public static PermUI perm;

    public LevelLoader ll;
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI levelText;

    public GameObject victory;
    public GameObject advertiser;

    public int level;
    public int score;

    public GameObject trueEmoji;
    public GameObject falseEmoji;

    public GameObject answerCanvas;
    public GameObject backStorImagesCanvas;
    public GameObject frontStoreImagesCanvas;

    public GameObject combatTextPlus;
    public GameObject combatTextMinus;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (!perm)
        {
            perm = this;
        }
        else
        {
            Destroy(gameObject);
        }

        score = 0;
        level = 0;

    }

    private void Update()
    {
        scoreTxt.text = "Score: " + score.ToString();
        levelText.text = "Level: " + level.ToString();
    }
}