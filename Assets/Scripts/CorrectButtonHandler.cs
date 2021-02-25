using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CorrectButtonHandler : MonoBehaviour
{
    private GameObject scrambleScreen;

    private void Awake()
    {
        scrambleScreen = GameObject.FindGameObjectWithTag("ScrambleScreen");
    }

    public void CorrectAnswerScrene()
    {
        PermUI.perm.combatTextScorePlus.SetActive(true);
        PermUI.perm.combatTextScorePlus.GetComponent<Animator>().SetTrigger("hit");
        scrambleScreen.SetActive(false);
        PermUI.perm.trueEmoji.SetActive(true);
        PermUI.perm.answerCanvas.SetActive(true);
        PermUI.perm.backStorImagesCanvas.SetActive(false);
        PermUI.perm.frontStoreImagesCanvas.SetActive(false);
        PermUI.perm.score += 100;

        if (PermUI.perm.level < 61)
        {
            PermUI.perm.level++;
        }
        
        PermUI.perm.ll.LoadNextLevel();
        SoundManager.PlaySound("CoinPickUp");
    }
}