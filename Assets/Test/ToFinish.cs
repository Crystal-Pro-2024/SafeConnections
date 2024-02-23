using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ToFinish : MonoBehaviour 
{

    Box Box1On = new Box(); 

    // Update is called once per frame
    void Update()
    {
        if (Box1On != null) 
        {
            SceneManager.LoadScene(1);
        }
    }
}
