using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketWithTagCheck : XRSocketInteractor
{
    SphereCollider x;
    public GameObject dru;
    private int i=0;
    public string targetTag = string.Empty;

    void Start()
    {
        x = dru.GetComponent<SphereCollider>();
    }

    public override bool CanHover(XRBaseInteractable interactable)
    {
        i = i + 1;
        x.enabled = false;
        return base.CanHover(interactable) && MatchUsingTag(interactable);


    }

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        print("Line 18 entered");
        return base.CanSelect(interactable) && MatchUsingTag(interactable);
        
    }
    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }
    // private void Update()
    // {
    //     x.enabled = true;
    // }
}
