using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador : MonoBehaviour
{
    public GameObject monos;
    public GameObject[] monosList;
    public float Tiempocreacion = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        monosList = GameObject.FindGameObjectsWithTag("Creeper");
        if (monosList.Length == 0) 
        {
            Creando();
            Debug.Log(monosList.Length);
        }
    }
    public void Creando()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 pos2 = new Vector3(Random.Range(155f,268f),-15.8f,Random.Range(405f,273f));
            Instantiate(monos, pos2, transform.rotation);
            
        }
     
        
      
    }
}
