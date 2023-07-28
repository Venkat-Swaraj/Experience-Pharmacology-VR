using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raytest : MonoBehaviour
{
    public GameObject forward;
    public float raycast_dist = 10.0f;
    public Animator eye;
    public GameObject LtL;
    public GameObject RtL;
    void Start()
    {
        
    }

   
     
     /*void Update()
     {
         RaycastHit hit;
         Ray lightRay = new Ray(forward.transform.localPosition, new Vector3(0,0, forward.transform.localPosition.normalized.z));
         if (Physics.Raycast(lightRay, out hit, raycast_dist))
         {
             Debug.Log(hit.collider.name);
             eye.SetBool("flash",true);
             LtL.SetActive(true);
             RtL.SetActive(true);
             
             
         }
         else
         {
             eye.SetBool("flash",false);
         }
         Debug.DrawRay(forward.transform.localPosition, new Vector3(0, 0, forward.transform.localPosition.normalized.z) * raycast_dist,Color.red);
        
     }*/
    /* void OnDrawGizmos()
     {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(lightRay);
     }*/
    void FixedUpdate()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(forward.transform.position, forward.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(forward.transform.position, forward.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            
            if(hit.collider.name == "eye_collider")
            {
                eye.SetBool("flash", true);
                LtL.SetActive(true);
                RtL.SetActive(true);
                Debug.Log("Did Hit" + hit.transform.name);
            }
            else
            {
                eye.SetBool("flash", false);
            }
        }
        else
        {
            Debug.DrawRay(forward.transform.position, forward.transform.TransformDirection(Vector3.forward) * 1000, Color.white);
          
            
        }
    }
}

