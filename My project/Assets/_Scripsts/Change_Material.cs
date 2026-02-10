using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Material : MonoBehaviour
{
    public Material secondMaterial;
    public GameObject Pino;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pino"))
        {
            Vector3 scaleChange = new Vector3(2f, 1f, 2f);
            collision.gameObject.GetComponent<Renderer>().material = secondMaterial;
            collision.gameObject.transform.localScale = scaleChange; 
            
        }
    }
}
