using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource x;
    void Start()
    {
        
    }
    public void Clicked()
    {
        x.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
