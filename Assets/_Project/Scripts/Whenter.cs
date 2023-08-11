using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whenter : MonoBehaviour
{
    public Animator eye;
    public Animator pressure;
    public Animator lid;
    public GameObject Ltp;
    public GameObject Ltl;
    public GameObject Ltc;
    public GameObject Rtp;
    public GameObject Rtl;
    public GameObject Rtc;
    //Rtp,Ltp,all three letter names belongs to canvas.
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        /*if (other.CompareTag("drug"))
        {
            eye.SetBool("drugInstilled",true);
        }*/
        if (other.CompareTag("meter")&& eye.GetBool("Epinephrine"))
        {
            pressure.SetBool("Pressure",true);
        }
        else if (other.CompareTag("cotton") && !eye.GetBool("Lignocaine"))
        {
            
                lid.SetBool("Feather", true);
                Invoke("featherFalse", 0.1f);
        }
    }

    public void druginst()
    {
        eye.SetBool("drugInstilled",true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Epinephrine"))
        {
            Invoke("druginst",1);
            eye.SetBool("Epinephrine",true);
            //eye.SetBool("drugInstilled",true);
            Rtp.SetActive(true);
            Ltp.SetActive(true);
        }
        else if(other.CompareTag("Ephedrine"))
        {
            Invoke("druginst", 1);
        }
        else if(other.CompareTag("Atropine"))
        {
            eye.SetBool("Atropine", true);
        }
        else if(other.CompareTag("cotton"))
        {
            Ltc.SetActive(true);
            Rtc.SetActive(true);
        }
        else if (other.gameObject.tag == "Lignocaine")
        {
            eye.SetBool("Lignocaine",true);
        }
        else if (other.gameObject.tag == "Physostigmine")
        {
            eye.SetBool("Physostigmine",true);
        }
    }

    private void featherFalse()
    {
        lid.SetBool("Feather", false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
