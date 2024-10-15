using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    // Introduce 3 n�meros y que el programa detecte si est�n introducidos en orden descendiente


    // Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {
        
        IsDescendingNumber (NumberOne, NumberTwo, NumberThree); // Paso por par�metro

    }

    private void IsDescendingNumber(int a, int b, int c) 
    {

        if (a >= b && b >= c)
        {
            Debug.Log("Los n�meros " + a + ", " + b + ", " + c + " est�n en orden descendiente.");
        }
        else 
        {
            Debug.Log("Los n�meros " + a + ", " + b + ", " + c + " NO est�n en orden descendiente.");
        }
    }

    
}
