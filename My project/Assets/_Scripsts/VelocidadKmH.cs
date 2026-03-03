using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadKmH : MonoBehaviour
{
    Rigidbody rb;
    public float velocidadActual;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Magnitud de la velocidad en m/s, convertida a km/h
        velocidadActual = rb.velocity.magnitude * 3.6f;
        Debug.Log("Velocidad: " + velocidadActual + " km/h");
    }
}
