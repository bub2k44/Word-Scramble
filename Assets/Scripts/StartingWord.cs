using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartingWord : MonoBehaviour
{
    private TextMeshProUGUI word;

    [SerializeField]
    private CorrectWord correctWord;

    private void Start()
    {
        word = GetComponent<TextMeshProUGUI>();

        word.text = correctWord.MyCorrectWord;
    }
}
