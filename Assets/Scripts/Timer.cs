using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countDownText;

    [SerializeField]
    private CanvasGroup timerCanvasGroup;

    [SerializeField]
    private CanvasGroup scrambleScreenCanvasGroup;

    private float currentTime = 0f;
    private float startingTime = 5f;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            timerCanvasGroup.alpha = 0;
            scrambleScreenCanvasGroup.alpha = 1;
            scrambleScreenCanvasGroup.interactable = true;
        }
    }
}