using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarEnemigos : MonoBehaviour
{
    public GameObject[] enemigos;
    int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemigos = GameObject.FindGameObjectsWithTag("Creeper");
        cont++;
        Debug.Log("has matado " + cont + " Creeper");

    }
}
