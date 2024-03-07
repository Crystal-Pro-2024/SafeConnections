using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishscene : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    public GameObject UIWIN;
    public bool Boxtrigger;
    public bool Boxtrigger2;
    public bool Boxtrigger3;
    public bool Boxtrigger4;

    // Update is called once per frame
    void Update()
    {
        if (Box1.activeInHierarchy == true)
        {
            Boxtrigger = true;
        }
        else if (Box1.activeInHierarchy == false) 
        { 
            Boxtrigger = false; 
        }
        if (Box2.activeInHierarchy == true)
        {
            Boxtrigger2 = true;
        }
        else if (Box2.activeInHierarchy == false)
        {
            Boxtrigger2 = false;
        }
        if (Box3.activeInHierarchy == true)
        {
            Boxtrigger3 = true;
        }
        else if (Box3.activeInHierarchy == false)
        {
            Boxtrigger3 = false;
        }
        if (Box4.activeInHierarchy == true)
        {
            Boxtrigger4 = true;
        }
        else if (Box4.activeInHierarchy == false)
        {
            Boxtrigger4 = false;
        }

        if(Boxtrigger == true && Boxtrigger2 == true && Boxtrigger3 == true && Boxtrigger4 == true) 
        {
            UIWIN.SetActive(true);
        }



    }
}
