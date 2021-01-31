using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using System;

public class ScrambledWord : MonoBehaviour
{
    private TextMeshProUGUI word;

    private string myScrambledWord;

    [SerializeField]
    private CorrectWord correctWord;

    private void Awake()
    {
        Scamble();
    }

    private void Start()
    {
        word = GetComponent<TextMeshProUGUI>();

        word.text = myScrambledWord;
    }

    private string Scamble()
    {
        var newString = new string(correctWord.MyCorrectWord.OrderBy(x => Guid.NewGuid()).ToArray());

        myScrambledWord = newString;

        return myScrambledWord;
    }
}
