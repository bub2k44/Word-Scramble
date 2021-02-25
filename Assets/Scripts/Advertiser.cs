using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Advertiser : MonoBehaviour
{
    [SerializeField]
    private Image[] images;

    [SerializeField]
    private GameObject[] backImages;

    private float currentTime = 0f;
    private float startingTime = 1f;
    private float speed = .2f;
    private int imageIndex = 0;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        FillHorizontalRight(0, 1);
        FillVerticalTop(1, 2);
        FillRadial180Left(2, 3);
        FillRadius360Right(3, 4);
        FillRadius90BottomRight(4, 5);
        FillRadius90BottomLeft(5, 6);
        FillHorizontalLeft(6, 7);
        FillRadial180Bottom(7, 8);
        FillVerticalBottom(8, 9);
        FillRadius360Bottom(9, 10);
        FillRadius90TopLeft(10, 11);
        FillRadius360Top(11, 12);
        FillRadius90TopRight(12, 13);
        FillRadial180Right(13, 14);
        FillHorizontalRight2(14, 15);
        FillRadius360Left(15, 16);
        FillRadius90BottomLeft2(16, 17);
        FillRadial180Top(17, 0); 
    }
    private void FillHorizontalRight(int index, int nextIndex)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 0)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Horizontal;
            images[index].fillOrigin = (int)Image.OriginHorizontal.Right;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 0)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[nextIndex].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillVerticalTop(int index, int nextIndex)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 1)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Vertical;
            images[index].fillOrigin = (int)Image.OriginVertical.Top;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 1)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[nextIndex].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadial180Left(int index, int indexNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 2)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial180;
            images[index].fillOrigin = (int)Image.Origin180.Left;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 2)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indexNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius360Right(int index, int indextNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 3)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial360;
            images[index].fillOrigin = (int)Image.Origin360.Right;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 3)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indextNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius90BottomRight(int index, int indextNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 4)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial90;
            images[index].fillOrigin = (int)Image.Origin90.BottomRight;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 4)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indextNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius90BottomLeft(int index, int indexNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 5)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial90;
            images[index].fillOrigin = (int)Image.Origin90.BottomLeft;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 5)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indexNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillHorizontalLeft(int index, int nextIndex)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 6)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Horizontal;
            images[index].fillOrigin = (int)Image.OriginHorizontal.Left;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 6)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[nextIndex].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadial180Bottom(int index, int indexNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 7)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial180;
            images[index].fillOrigin = (int)Image.Origin180.Bottom;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 7)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indexNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillVerticalBottom(int index, int nextIndex)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 8)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Vertical;
            images[index].fillOrigin = (int)Image.OriginVertical.Bottom;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 8)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[nextIndex].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius360Bottom(int index, int indextNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 9)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial360;
            images[index].fillOrigin = (int)Image.Origin360.Bottom;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 9)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indextNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius90TopLeft(int index, int indextNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 10)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial90;
            images[index].fillOrigin = (int)Image.Origin90.TopLeft;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 10)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indextNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius360Top(int index, int indextNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 11)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial360;
            images[index].fillOrigin = (int)Image.Origin360.Top;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 11)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indextNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius90TopRight(int index, int indextNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 12)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial90;
            images[index].fillOrigin = (int)Image.Origin90.TopRight;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 12)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indextNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadial180Right(int index, int indexNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 13)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial180;
            images[index].fillOrigin = (int)Image.Origin180.Right;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 13)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indexNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillHorizontalRight2(int index, int nextIndex)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 14)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Horizontal;
            images[index].fillOrigin = (int)Image.OriginHorizontal.Right;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 14)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[nextIndex].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius360Left(int index, int indextNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 15)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial360;
            images[index].fillOrigin = (int)Image.Origin360.Left;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 15)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indextNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadius90BottomLeft2(int index, int indexNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 16)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial90;
            images[index].fillOrigin = (int)Image.Origin90.BottomLeft;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 16)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indexNext].fillAmount = 1;

            imageIndex += 1;
            currentTime = startingTime;
        }
    }
    private void FillRadial180Top(int index, int indexNext)
    {
        if (images[index].fillAmount >= 0 && imageIndex == 17)
        {
            backImages[index].SetActive(true);
            currentTime -= speed * Time.deltaTime;
            images[index].fillMethod = Image.FillMethod.Radial180;
            images[index].fillOrigin = (int)Image.Origin180.Top;
            images[index].fillAmount = currentTime;
        }
        if (images[index].fillAmount <= 0 && imageIndex == 17)
        {
            backImages[index].SetActive(false);
            images[index].fillAmount = 0;
            images[indexNext].fillAmount = 1;

            imageIndex = 0;
            currentTime = startingTime;
        }
    }
}