using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Advertiser : MonoBehaviour
{
    [SerializeField]
    private Image[] images;

    private float currentTime = 0f;
    private float startingTime = 1f;
    private int imageIndex = 0;

    private bool isImage0 = true;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        if (images[0].fillAmount >= 0 && imageIndex == 0)
        {
            currentTime -= .5f * Time.deltaTime;
            images[0].fillMethod = Image.FillMethod.Horizontal;
            images[0].fillAmount = currentTime;
        }
        if (images[0].fillAmount <= 0 && imageIndex == 0)
        {
            images[0].fillAmount = 0;
            images[1].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }

        if (images[1].fillAmount >= 0 && imageIndex == 1)
        {
            currentTime -= .5f * Time.deltaTime;
            images[1].fillMethod = Image.FillMethod.Vertical;
            images[1].fillAmount = currentTime;
        }
        if (images[1].fillAmount <= 0 && imageIndex == 1)
        {
            images[1].fillAmount = 0;
            images[2].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }

        if (images[2].fillAmount >= 0 && imageIndex == 2)
        {
            currentTime -= .5f * Time.deltaTime;
            images[2].fillMethod = Image.FillMethod.Radial180;
            images[2].fillAmount = currentTime;
        }
        if (images[2].fillAmount <= 0 && imageIndex == 2)
        {
            images[2].fillAmount = 0;
            images[3].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }

        if (images[3].fillAmount >= 0 && imageIndex == 3)
        {
            currentTime -= .5f * Time.deltaTime;
            images[3].fillMethod = Image.FillMethod.Radial360;
            images[3].fillAmount = currentTime;
        }
        if (images[3].fillAmount <= 0 && imageIndex == 3)
        {
            images[3].fillAmount = 0;
            images[4].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }

        if (images[4].fillAmount >= 0 && imageIndex == 4)
        {
            currentTime -= .5f * Time.deltaTime;
            images[4].fillMethod = Image.FillMethod.Radial90;
            images[4].fillAmount = currentTime;
        }
        if (images[4].fillAmount <= 0 && imageIndex == 4)
        {
            images[4].fillAmount = 0;
            images[5].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
}
