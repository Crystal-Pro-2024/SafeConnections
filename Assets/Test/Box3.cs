using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box3 : MonoBehaviour
{
    public GameObject box3;
    public GameObject boxTrigger3;
    public int Box3On;

    public void OnTriggerEnter(Collider other)
    {
        Box3On = 1;
        boxTrigger3.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        Box3On = 0;
        boxTrigger3.SetActive(false);
    }
}
