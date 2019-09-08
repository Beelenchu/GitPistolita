using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBala : MonoBehaviour
{
    int cont = 0;
    Renderer colorcubo;
    // Start is called before the first frame update
    void Start()
    {
        colorcubo = GetComponent<Renderer>();
        colorcubo.material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            cont++;
            if (cont == 5)
            {
                cont = 0;
            }
        }

        Debug.Log("se a contado " + cont);

        switch (cont)
        {
            case 0:
                colorcubo.material.SetColor("_Color", Color.red);
                break;
            case 1:
                colorcubo.material.SetColor("_Color", Color.magenta);
                break;
            case 2:
                colorcubo.material.SetColor("_Color", Color.green);
                break;
            case 3:
                colorcubo.material.SetColor("_Color", Color.blue);
                break;
            case 4:
                colorcubo.material.SetColor("_Color", Color.black);
                break;
        }
    }
}
