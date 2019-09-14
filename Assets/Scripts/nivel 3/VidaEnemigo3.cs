using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo3 : MonoBehaviour
{
    public float VidaE = 120f;
    public int RestarVida = 30;

    public bool muerto = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (VidaE <= 0)
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
