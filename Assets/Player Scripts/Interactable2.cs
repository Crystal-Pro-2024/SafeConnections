using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //just a template
    }
}

