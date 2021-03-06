﻿using UnityEngine;
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
    public GameObject combatTextScorePlus;
    public GameObject combatTextScoreMinus;
    public GameObject combatTextLevelPlus;
    public Balloons[] ballons;
    public Collider2D coll;

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
        level = 1;
    }

    private void Update()
    {
        scoreTxt.text = "Score: " + score.ToString();

        if (level < 61)
        {
            levelText.text = "Level: " + level.ToString();
        }
        else
        {
            levelText.text = "Level: " + 60.ToString();
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            for (int i = 0; i < PermUI.perm.ballons.Length; i++)
            {
                PermUI.perm.ballons[i].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
        }
    }
}