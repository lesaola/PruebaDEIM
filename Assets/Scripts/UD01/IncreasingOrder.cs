using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    // Introduce 3 n�meros y que el programa detecte si est�n introducidos en orden ascendiente


    // Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {
        IsAscendingNumber(NumberOne, NumberTwo, NumberThree); // Paso por par�metro
    }




    private void IsAscendingNumber(int a, int b, int c) 
    {
        if (a < b && b < c) 
        {
            Debug.Log("Los n�meros " + a + ", " + b + ", " + c + " est�n en orden ascendiente.");
        }
        else
        {
            Debug.Log("Los n�meros " + a + ", " + b + ", " + c + " NO est�n en orden ascendiente");
        }
    }



}
