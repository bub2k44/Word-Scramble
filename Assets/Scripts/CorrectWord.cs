using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CorrectWord : MonoBehaviour
{
    private TextMeshProUGUI word;

    [SerializeField]
    private string myCorrectWord;

    public string MyCorrectWord { get => myCorrectWord; set => myCorrectWord = value; }

    private void Start()
    {
        word = GetComponent<TextMeshProUGUI>();

        word.text = MyCorrectWord;
    }
}
