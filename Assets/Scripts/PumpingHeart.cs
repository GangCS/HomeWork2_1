using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PumpingHeart : MonoBehaviour
{
    /* this scripts scales the object like a pumping heart */
    bool need2enlarge = true;
    [Tooltip("scaling the heart")]
    [SerializeField]
    float scalingSpeed = 1f;
    [Tooltip("Maximum scale")]
    [SerializeField]
    float scaleMax = 3f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Checking if the scale is lower then scaleMax and if the object should grow
        if (transform.localScale.x < scaleMax && need2enlarge)
            transform.localScale += new Vector3(scalingSpeed * Time.deltaTime, scalingSpeed * Time.deltaTime, scalingSpeed * Time.deltaTime);
        else
        {
            // stop the object from scaling lower then original size
            if (transform.localScale.x > 1)
            {
                need2enlarge = false;
                // scaling the object down
                transform.localScale -= new Vector3(scalingSpeed * Time.deltaTime, scalingSpeed * Time.deltaTime, scalingSpeed * Time.deltaTime);
            }
            else
                need2enlarge = true;
        }
            
    }
}
