using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighton : MonoBehaviour
{
    // Start is called before the first frame update
    public Light l;
    public Raytest _raytest;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void WhenClick()
    {
        l.enabled = !l.enabled;
        _raytest.enabled=!_raytest.enabled;
        if(!_raytest.enabled)
        {
            _raytest.eye.SetBool("flash", false);
        }
    }
    void Update()
    {
        
    }
}
