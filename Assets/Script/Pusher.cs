﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    Vector3 startPosition;

    public float amplitude;
    public float speed;

    private void Start()
    {
        startPosition = transform.localPosition;
    }

    private void Update()
    {
        //変位を計算
        float z = amplitude * Mathf.Sin(Time.time * speed);

        //zを変位させたポジションに再設定
        transform.localPosition = startPosition + new Vector3(0, 0, z);
    }

}

