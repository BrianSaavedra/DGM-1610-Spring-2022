using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalculator : MonoBehaviour
{
    // Access Modifier DataType;
    public int numberA = 10;
    public int numberB = 33;
    public int numberC = 7;

    // + - * / %
    // Start is called before the first frame update
    void Start()
    {
        Add();
        Sub();
        Mult();
        divide();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void Add()
    {
        int total;

        total = numberA + numberB;

        Debug.Log(numberA +" + "+ numberB +" = "+ total);

    }

    void Sub()
    {
         int total;

        total = numberB - numberC;

        Debug.Log(numberB +" - "+ numberC +" = "+ total);
    }

    void Mult()
    {
         int total;

        total = numberB * numberB;

        Debug.Log(numberB +" * "+ numberB +" = "+ total);
    }

    void divide()
    {
         int total;
         int rem;

        total = numberB / numberC;
        rem = numberB % numberC;

        Debug.Log(numberB +" / "+ numberC +" = "+ total);
        Debug.Log("Remainder = " + rem );


    }

}
