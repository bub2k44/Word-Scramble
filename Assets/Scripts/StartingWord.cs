using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartingWord : MonoBehaviour
{
    private CorrectWord correctWord;
    private TextMeshProUGUI word;

    private void Awake()
    {
        correctWord = FindObjectOfType<CorrectWord>();
    }

    private void Start()
    {
        word = GetComponent<TextMeshProUGUI>();
        word.text = correctWord.MyCorrectWord;
    }
}