using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCreeper : MonoBehaviour
{
    public float velocidad;
    public float distancia;
   // public float y;
    //public float z;
    float x = -3;
    float posini;
    // Start is called before the first frame update
    void Start()
    {
        posini = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * velocidad, distancia) + posini, transform.position.y);
    }
}
