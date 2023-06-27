using System;
using UnityEngine;

public class Feather : MonoBehaviour
{
    Animator _Anim;
    public GameObject anim;
    // Start is called before the first frame update

    public void featherTrue()
    {
        _Anim.SetBool("Feather", true);
        Invoke("featherFalse",0.1f);
    }

    private void featherFalse()
    {
        _Anim.SetBool("Feather",false);
    }
    
    
    void Start()
    {
        _Anim = anim.GetComponent<Animator>();
    }
    
}