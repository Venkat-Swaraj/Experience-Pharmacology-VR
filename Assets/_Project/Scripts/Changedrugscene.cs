using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changedrugscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void whendrugpicked(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
