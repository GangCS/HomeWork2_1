using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private float Epsilon = 3f;
    [SerializeField]
    private float BaseSpeed = 12f;
    private bool right = true;
    private float distance;
    private float maxX;
    private SpriteRenderer SR;
    // Start is called before the first frame update

    void Start()
    {
        //Gathering camera bounds
        float y = Camera.main.orthographicSize;
        float x = Camera.main.aspect;
        SR = GetComponent<SpriteRenderer>();
        // Calculating Maximum X
        maxX = y * x;
        Debug.Log(maxX);
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            // Calculating distance from object to max X of the frame

            distance = Math.Abs(maxX - transform.position.x);
            //Adding to the current position the distance the object should travel
            //The closer the object to maxX(upper bound) the slower it will become
            transform.position += new Vector3(BaseSpeed * (distance * 2 / maxX) * Time.deltaTime, 0, 0);
            if (transform.position.x >= maxX - Epsilon)
            {

                SR.flipX = true;
                right = false;
            }
        }
        else
        {
            // Calculating distance from object to max X of the frame
            distance = Math.Abs(-maxX - transform.position.x);
            //Adding to the current position the distance the object should travel
            //The closer the object to Minus maxX(lower bound) the slower it will become
            transform.position += new Vector3(-BaseSpeed * (distance * 2 / maxX) * Time.deltaTime, 0, 0);
            if (transform.position.x <= -maxX + Epsilon)
            {
                SR.flipX = false;
                right = true;
            }
        }
    }
}

