using UnityEngine;
using TMPro;
using System.Linq;
using System;

public class ScrambledWord : MonoBehaviour
{
    private CorrectWord correctWord;
    private TextMeshProUGUI word;
    private string myScrambledWord;

    private void Awake()
    {
        correctWord = FindObjectOfType<CorrectWord>();
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
        
        if (correctWord.MyCorrectWord == myScrambledWord)
        {           
            Scamble();

            return null;
        }
        else
        {
            return myScrambledWord;
        }
    }
}