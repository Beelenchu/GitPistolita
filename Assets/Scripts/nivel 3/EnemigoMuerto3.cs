using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMuerto3 : MonoBehaviour
{
    GameObject[] monosList;

    private GameController gameController;
    public int scoreValor;


    VidaEnemigo3 EnemigoVida;
    GameObject EnemigoMuertoG;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        EnemigoVida = GetComponent<VidaEnemigo3>();


    }

    // Update is called once per frame
    void Update()
    {
        monosList = GameObject.FindGameObjectsWithTag("Creeper");
        // Debug.Log(monosList.Length);


        if (EnemigoVida.muerto == true)
        {
            gameController.AddScore(scoreValor);
            Destroy(this.gameObject);

            // Debug.Log("eliminado");

        }
    }

}
