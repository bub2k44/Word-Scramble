using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CorrectWord : MonoBehaviour
{
    [SerializeField]
    private string myCorrectWord;

    private TextMeshProUGUI word;

    public string MyCorrectWord { get => myCorrectWord; set => myCorrectWord = value; }

    private void Start()
    {
        word = GetComponent<TextMeshProUGUI>();
        word.text = MyCorrectWord;
    }
}