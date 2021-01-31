using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Randomizer : MonoBehaviour
{
    [SerializeField]
    private GameObject button1;
    [SerializeField]
    private GameObject button2;
    [SerializeField]
    private GameObject button3;
    [SerializeField]
    private GameObject button4;
    [SerializeField]
    private GameObject button5;

    [SerializeField]
    private List<GameObject> words = new List<GameObject>();

    private void Start()
    {
        foreach (GameObject word in words)
        {

        }
    }
}
