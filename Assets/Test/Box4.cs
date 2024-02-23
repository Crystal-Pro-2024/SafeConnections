using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box4 : MonoBehaviour
{
    public GameObject box1;
    public int Box4On;

    public void OnTriggerEnter(Collider other)
    {
        Box4On = 1;
    }

    public void OnTriggerExit(Collider other)
    {
        Box4On = 0;
    }
}
