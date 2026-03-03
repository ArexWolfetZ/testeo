using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLuz : MonoBehaviour
{
    public Light luz;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        { 
            luz.enabled = !luz.enabled;
        }
    }
}

