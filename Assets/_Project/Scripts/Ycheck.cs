using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ycheck : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 x;
    void Start()
    {
        x = this.transform.position;
    }

    // Update is called once per frame
    public void change()
    {
        this.transform.position = x;
    }
    void Update()
    {
        if (this.transform.position.y < -1)
        {
            Invoke("change",1);
        }
    }
    
}
