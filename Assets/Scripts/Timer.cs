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
    private float startingTime = 1f;//1
    private float speed = .1f;//.3

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        FillRadius360Top();

        if (codeFace.fillAmount <= 0)
        {
            canvasGroup.alpha = 0;
            currentTime = 0;
            timerCanvasGroup.alpha = 0;
            scrambleScreenCanvasGroup.alpha = 1;
            scrambleScreenCanvasGroup.interactable = true;
            gameObject.SetActive(false);
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
            var tempTime = currentTime * 10;//5
            countDownText.text = tempTime.ToString("0");
            codeFace.fillMethod = Image.FillMethod.Radial360;
            codeFace.fillOrigin = (int)Image.Origin360.Top;
            codeFace.fillAmount = currentTime;
        }
    }
}