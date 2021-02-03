using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectButtonHandler : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup correctAnswercanvasGroup;

    private GameObject scrambleScreen;
    private GameObject correctAnswer;

    private void Awake()
    {
        scrambleScreen = GameObject.FindGameObjectWithTag("ScrambleScreen");
    }

    public void CorrectAnswerScrene()
    {
        scrambleScreen.SetActive(false);
        correctAnswercanvasGroup.alpha = 1;
        PermUI.perm.score += 100;
        PermUI.perm.ll.LoadNextLevel();
        SoundManager.PlaySound("CoinPickUp");
    }
}