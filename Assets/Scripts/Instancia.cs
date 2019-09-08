using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancia : MonoBehaviour
{

    public GameObject obj;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           GameObject cubebala = Instantiate(obj, transform.position, transform.rotation) as GameObject;       
            Destroy(cubebala, 2f);  
          
        }
           
    }
}
