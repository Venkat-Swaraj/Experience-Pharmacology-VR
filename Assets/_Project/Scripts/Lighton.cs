using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighton : MonoBehaviour
{
    // Start is called before the first frame update
    public Light l;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    public void WhenClick()
    {
        l.enabled = !l.enabled;
    }
    void Update()
    {
        
    }
}
