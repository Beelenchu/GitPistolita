using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{

    public GameObject balita;
    
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Creeper")
        {
            Destroy(collision.gameObject);
            Destroy(balita);
        }

    }
    
}
