using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement2 : MonoBehaviour
{
    public Transform target;
    [SerializeField] private Vector3 Offset;
    [SerializeField] private float  Followspeed;
    //ewe   
    void LateUpdate()
    {
        FollowTarget();
    }
    //camara persiga al enemigo
    public void FollowTarget()
    {
        if (target != null)
        {
            var targetPos = target.position + Offset;
            transform.position = targetPos; 

        }
    }
}
