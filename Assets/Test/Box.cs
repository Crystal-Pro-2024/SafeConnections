using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject box1;
    public GameObject boxTrigger1;
    public int Box1On;

    public void OnTriggerEnter(Collider other)
    {
        Box1On = 1;
        boxTrigger1.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        Box1On = 0;
        boxTrigger1.SetActive(false);
    }
}
