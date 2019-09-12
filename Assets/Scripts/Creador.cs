using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador : MonoBehaviour
{
    public GameObject monos;
    public float Tiempocreacion = 5f, Rangocreacion = 80f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creando",0.0f, Tiempocreacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Creando()
    {
        //transform.position = new Vector3(Mathf.PingPong(Time.time * velocidad, distancia) + posRandom, transform.position.y, posa);
        Vector3 pos = new Vector3(0,0,0);
        pos = this.transform.position + Random.onUnitSphere * Rangocreacion;
        pos = new Vector3(pos.x-150, this.transform.position.y, 90);
        Debug.Log("Pos ini ->" + pos.x);
        GameObject mono = Instantiate(monos, pos, Quaternion.identity);
    }
}
