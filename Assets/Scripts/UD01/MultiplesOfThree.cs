using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{

    // Muestra los m�ltiplos de 3 que se encuentren del 1 al 100.

    // Sin Variables Globales

    // Start is called before the first frame update
    void Start()
    {

        GetMultiplesOfThree(); 

    }

    private void GetMultiplesOfThree() 
    {

        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0) // Si el resto de la divisi�n por 3 es 0, es que el n�mero es m�ltiplo de 3.
            {
                Debug.Log(i);
            }
        
        }
    
    }


}
