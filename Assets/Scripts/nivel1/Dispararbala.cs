using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispararbala : MonoBehaviour
{
 
    public float velocidad = 100f;
    
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
            GetComponent<Rigidbody>().velocity = transform.forward * velocidad;
       
    }
}
