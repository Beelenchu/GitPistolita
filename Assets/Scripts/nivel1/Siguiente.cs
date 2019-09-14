using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Siguiente : MonoBehaviour
{
 
 
    public void next( string nombre)
    {
        SceneManager.LoadScene(nombre);
       
    }
    

}
