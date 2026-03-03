using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints_ : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<ChekpointManager>().checkPoint = transform;
        }
    }
}
