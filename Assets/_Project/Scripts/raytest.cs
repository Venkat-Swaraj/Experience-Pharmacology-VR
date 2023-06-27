using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raytest : MonoBehaviour
{
    public GameObject forward;
    public float raycast_dist = 10.0f;
    public Animator eye;
    public GameObject LtL;
    public GameObject RtL;
    void Start()
    {
        
    }

   
     
     void Update()
     {
         RaycastHit hit;
         Ray lightRay = new Ray(forward.transform.position, forward.transform.forward);
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
             Debug.DrawRay(forward.transform.position, forward.transform.forward*raycast_dist,Color.red);
         //void OnDrawGizmos()
         //{
           //  Gizmos.color = Color.red;
             //Gizmos.DrawRay(lightRay);
         //}
     }
    }

