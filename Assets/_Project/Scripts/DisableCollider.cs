using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public SphereCollider x;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        x.enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        x.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
