using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resettriggercy : MonoBehaviour
{
    

    public Vector3 x;
    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position;
    }

    // Update is called once per frame
    
    void Update()
    {
        if (this.transform.position.y < 0.5)
        {
            print("Toucjed");
            print(this.transform.position.y);
            this.transform.position = x;
        }

    }
}
