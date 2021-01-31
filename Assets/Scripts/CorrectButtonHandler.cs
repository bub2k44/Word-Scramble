using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectButtonHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject scrambleScreen;

    [SerializeField]
    private GameObject correctAnswer;

    public void CorrectAnswerScrene()
    {
        scrambleScreen.SetActive(false);
        correctAnswer.SetActive(true);
    }
}
