using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rapidez : MonoBehaviour
{
    private Rigidbody rb;
    public TextMeshProUGUI speedText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        ShowKM();

    }

    public void ShowKM()
    {
        speedText.text = rb.velocity.magnitude.ToString("0") + " km/h";
    }
}
