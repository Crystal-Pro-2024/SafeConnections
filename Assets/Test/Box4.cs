using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box4 : MonoBehaviour
{
    public GameObject box4;
    public GameObject boxTrigger4;
    public int Box4On;

    public void OnTriggerEnter(Collider other)
    {
        Box4On = 1;
        boxTrigger4.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        Box4On = 0;
        
        boxTrigger4.SetActive(false);
    }
}
