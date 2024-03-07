using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2 : MonoBehaviour
{
    public GameObject box2;
    public GameObject boxTrigger2;
    public int Box2On;

    public void OnTriggerEnter(Collider other)
    {
        Box2On = 1;
        boxTrigger2.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        Box2On = 0;
        boxTrigger2.SetActive(false);
    }
}
