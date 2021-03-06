﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyButtonHandler : MonoBehaviour
{
    public Button button;

    private LevelLoader ll;

    private void Awake()
    {
        ll = FindObjectOfType<LevelLoader>();
    }

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonPress);
    }

    public void ButtonPress()
    {
        ll.LoadLevelEasy();
    }
}