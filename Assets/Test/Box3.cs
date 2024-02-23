using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box3 : MonoBehaviour
{
    public GameObject box1;
    public int Box3On;

    public void OnTriggerEnter(Collider other)
    {
        Box3On = 1;
    }

    public void OnTriggerExit(Collider other)
    {
        Box3On = 0;
    }
}
