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

    public WordList wordList;

    public int level;
    public int score;

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