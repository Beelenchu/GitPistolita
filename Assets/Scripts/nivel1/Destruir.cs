using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{

      
    void Start()
    {
      
    }

    
    void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.tag == "Creeper")
        {    
            Destroy(this.gameObject);
           
        }
    }
}
