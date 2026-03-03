using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitido : MonoBehaviour
{
    public AudioSource pitido;
    public AudioClip clip;
    void start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
         {
            pitido.PlayOneShot(clip);
        }
      
    }
}

