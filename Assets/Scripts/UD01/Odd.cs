using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{

    // Muestra los n�meros impares entre el 0 y el 100.

    // Valores Globales (No har�an falta en este caso, porque no se introduce ning�n valor concreto)


    // Start is called before the first frame update
    void Start()
    {
        GetOddNumbers();  
    }

    private void GetOddNumbers()
    {

        for (int i = 0; i < 100; i++) // Con esto recorre los n�meros del 1 al 100 (o bien "int = 1; while (i < 100) { if (1 % 2 != 0) {Debug.Log(i);} i++;} }")
        {

            if (i % 2 != 0)           // Con esto ponemos de condici�n que el resto NO sea igual a 0 al dividirse por 2 y por lo tanto -
            {
                Debug.Log(i);         // - nos debugea exclusivamente los n�meros impares del intervalo.
            }
        
        } 
    
    }
}
