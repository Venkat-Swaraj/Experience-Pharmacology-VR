using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{
    [SerializeField] public GameObject flashLight;
    Animator _Anim;
    public GameObject anim;

    private bool flash_status;
    // Start is called before the first frame update
    void Start()
    {
        _Anim = anim.GetComponent<Animator>();
    }

    public void flash_light()
    {
        flashLight.SetActive(!(flashLight.activeSelf));
        _Anim.SetBool("flash",!(_Anim.GetBool("flash")));
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
