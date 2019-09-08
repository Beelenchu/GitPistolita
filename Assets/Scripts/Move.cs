using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float movimiento = 50f;
    
    void Start()
    {
       
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
        transform.Rotate(new Vector3(0f, -movimiento, 0f) * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0f, movimiento, 0f) * Time.deltaTime);
        }

        Mover();
    }
   
    void Mover()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * movimiento * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * movimiento * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * movimiento * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * movimiento * Time.deltaTime);
    }
}
