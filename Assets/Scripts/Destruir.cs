using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*  
      void ChocarCon(Collision choque)
      {
           if (choque.gameObject.tag == "Creeper")
               Destroy(choque.gameObject);


      }
      */
    /*
  private void OncollisionEnter(Collision obj)
  {
      if (obj.gameObject.tag == "Creeper")
          Destroy(obj.gameObject, 1f);
  }

  */

    /* void update()
      {
   GameObject mono = Instantiate(obj, transform.position, transform.rotation) as GameObject;
          Destroy(mono, 1f);
      }
    */



    // public GameObject obj;

    /*
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Destroy(obj);
        }
    }
    
*/
    
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Creeper")
            Destroy(collision.gameObject);

    }
    
}
