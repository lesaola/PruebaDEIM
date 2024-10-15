using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Muestra los m�ltiplos de 2 y 3 que se encuentren del 1 al 100.

    // Sin Variables Globales

    // Start is called before the first frame update
    void Start()
    {

        GetMultiples();
        
    }

    private void GetMultiples() 
    {


        for (int i = 0; i < 100; i++) 
        {


            if (i % 2 == 0) // Si el resto al dividirse por 2 es 0, es m�ltiplo de 2.
            {

                Debug.Log(i + ", m�ltiplo de DOS.");
            
            }


            if (i % 3 == 0) // Lo mismo pasa si se divide por 3.
            {

                Debug.Log(i + ", m�ltiplo de TRES.");
            
            }
        
        }
    
    }


}
