﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for (int i = 4; i < students.Length; i--)
        {
            Debug.Log((i + 1) + "번 학색의 점수 : " + students[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
