using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancia : MonoBehaviour
{

    public GameObject obj;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           
            GameObject cubebala = Instantiate(obj, transform.position, transform.rotation) as GameObject;    
            Destroy(cubebala, 1f);  
            
          
        }
           
    }
    
}
