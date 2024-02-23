using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2 : MonoBehaviour
{
    public GameObject box1;
    public int Box2On;

    public void OnTriggerEnter(Collider other)
    {
        Box2On = 1;
    }

    public void OnTriggerExit(Collider other)
    {
        Box2On = 0;
    }
}
