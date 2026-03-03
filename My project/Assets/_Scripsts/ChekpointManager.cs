using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekpointManager : MonoBehaviour
{
    [HideInInspector] public Transform checkPoint;
    public Transform startPos;
    // Start is called before the first frame update
    void Start()
    {
        checkPoint = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        CarReset();
    }

    public void CarReset()
    {
         if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = checkPoint.position;
        }
    }
}
