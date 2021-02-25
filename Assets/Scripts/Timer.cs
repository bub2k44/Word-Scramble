using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countDownText;

    [SerializeField]
    private CanvasGroup timerCanvasGroup;

    [SerializeField]
    private CanvasGroup scrambleScreenCanvasGroup;

    [SerializeField]
    private Image codeFace;

    [SerializeField]
    private CanvasGroup canvasGroup;

    private float currentTime;
    private float startingTime = .1f;
    private float speed = .3f;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        //codeFace.fillAmount = currentTime;
        //currentTime -= 1 * Time.deltaTime;
        //countDownText.text = currentTime.ToString("0");
        //codeFace.fillAmount = currentTime;
        //Debug.Log("CodeFace");
        //DEBUGG

        FillRadius360Top();

        if (codeFace.fillAmount <= 0)
        {
            canvasGroup.alpha = 0;
            currentTime = 0;
            timerCanvasGroup.alpha = 0;
            scrambleScreenCanvasGroup.alpha = 1;
            scrambleScreenCanvasGroup.interactable = true;
            
            //codeFace.fillAmount = startingTime;
        }
        if (codeFace.fillAmount > 0)
        {
            scrambleScreenCanvasGroup.interactable = false;
        }
    }

    private void FillRadius360Top()
    {
        if (codeFace.fillAmount >= 0)
        {
            currentTime -= speed * Time.deltaTime;
            var tempTime = currentTime * 5;
            countDownText.text = tempTime.ToString("0");
            codeFace.fillMethod = Image.FillMethod.Radial360;
            codeFace.fillOrigin = (int)Image.Origin360.Top;
            codeFace.fillAmount = currentTime;
        }
    }
}