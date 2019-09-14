using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador2 : MonoBehaviour
{
    public GameObject monos;
    public int maxcreeper = 10;
    GameObject[] monosList;

    // Start is called before the first frame update
    void Start()
    {
        Creando();

    }
    void Update()
    {
        monosList = GameObject.FindGameObjectsWithTag("Creeper");
        if (monosList.Length == 0)
        {
            Application.LoadLevel(3);
        }
    }


    public void Creando()
    {

        for (int i = 0; i < maxcreeper; i++)
        {
            Vector3 pos2 = new Vector3(Random.Range(155f, 268f), -15.8f, Random.Range(405f, 273f));
            Instantiate(monos, pos2, transform.rotation);

        }


    }

}
