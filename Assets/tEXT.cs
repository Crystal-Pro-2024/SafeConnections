using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tEXT : MonoBehaviour
{

    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(intro());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator intro()
    {
        while (true)
        {


            yield return new WaitForSeconds(4);
            Text.SetActive(false);
           

        }
    }
}
