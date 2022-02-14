using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private const float V = 2.0f;
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float rotate = V;
    private Transform startPos;


    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);


    }
}