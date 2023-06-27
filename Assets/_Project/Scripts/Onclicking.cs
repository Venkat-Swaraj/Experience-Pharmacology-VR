using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;
using UnityEngine.InputSystem;

public class Onclicking : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator hand;
    public InputActionProperty pinchanimationaction;
    public InputActionProperty gripanimationaction;
    public 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggervalue = pinchanimationaction.action.ReadValue<float>();
        float gripvalue = gripanimationaction.action.ReadValue<float>();
        hand.SetFloat("Trigger",triggervalue);
        hand.SetFloat("Grip",gripvalue);
    }
}
