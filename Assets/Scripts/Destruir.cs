using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    int contador=0;
    GameObject obj;
    void Start()
    {

    }
    /*void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Creeper")
        {       
            
            Destroy(collision.gameObject);
            Destroy(balita);
            contador++;
        }

       void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Creeper")
            Destroy(collision.gameObject);
        contador++;
        Debug.Log("has matado " + contador + " Creeper");

    }
        */
/*
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Creeper")
        {
            Destroy(other.gameObject);
        }
    }
*/

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Creeper")
        {
            Destroy(collision.gameObject);
           
            
        }
      

    }


}
