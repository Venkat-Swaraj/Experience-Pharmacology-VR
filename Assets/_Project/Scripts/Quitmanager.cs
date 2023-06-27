using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitmanager : MonoBehaviour
{
    public AudioSource x;
    public void close()
    {
        x.Play();   
        Application.Quit();
    }
    
}
