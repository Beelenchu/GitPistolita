using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    public GameObject mono;
   
    public float velocidad;
    public float distancia;
  
    float posini;
    float posa;

    // Start is called before the first frame update
    void Start()
    {
       
        posini = transform.position.x;
        posa = transform.position.z;
    }

    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * velocidad, distancia) + posa, transform.position.y, posini);

        Destroy(mono, 3f);

    }
}
