using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we have two objects one is rotating by Y and the other by Z
        if (gameObject.name.CompareTo("Coin") == 0)
        {
            transform.Rotate(new Vector3(0f, 1f, 0f) * Time.deltaTime * speed);
        }
        else
        {
            transform.Rotate(new Vector3(0f, 0f, 1f) * Time.deltaTime * speed);
        }
    }
}
