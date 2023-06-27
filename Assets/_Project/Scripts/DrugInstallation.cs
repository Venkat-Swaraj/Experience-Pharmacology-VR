using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugInstallation : MonoBehaviour
{
    Animator _Anim;
    public GameObject anim;
    // Start is called before the first frame update

    public void Drug()
    {
        _Anim.SetBool("drugInstilled", true);
    }
    void Start()
    {
        _Anim = anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}