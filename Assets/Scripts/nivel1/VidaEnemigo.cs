﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public float VidaE = 100f;
    public int RestarVida = 50;

    public bool muerto = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(VidaE <= 0)
        {
            muerto = true;
           
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bala")
        {
            VidaE -= RestarVida;
            Debug.Log("vidaE -- " + VidaE);
        }
    }
}
