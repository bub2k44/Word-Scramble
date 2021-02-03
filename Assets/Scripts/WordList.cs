using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordList : MonoBehaviour
{
    private List<string> easyWords;
    private CorrectWord correctWord;

    private void Start()
    {
        correctWord = FindObjectOfType<CorrectWord>();

        easyWords = new List<string>
        {
            "word1",
            "word2",
            "word3",
            "word4", 
            "word5", 
            "word6",
            "word7",
            "word8",
        };
    }

    public void LoadWord()
    {
        if (easyWords.Count == 0)
        {
            return;
        }

        int randomIndex = Random.Range(0, easyWords.Count);
        string currentWord = easyWords[randomIndex];
        easyWords.RemoveAt(randomIndex);
        correctWord.MyCorrectWord = currentWord;
    }
}