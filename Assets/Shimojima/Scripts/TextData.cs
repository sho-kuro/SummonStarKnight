﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextData : MonoBehaviour
{
    public List<string> textData;
    public bool loadFinish = false;
    private string scenario;

    void Start()
    {
        
        TextAsset ta = Resources.Load<TextAsset>("Scenario/Scenario");
        string s = ta.text;
        string[] ss = s.Split('\n');
        int i = 0;
        while (i < ss.Length)
        {
            textData.Add(ss[i]);
            i++;
        }
        i = 0;
        loadFinish = true;
    }
}