using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // On clicking S the renderer component will switch activity 
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
        }
    }
}
