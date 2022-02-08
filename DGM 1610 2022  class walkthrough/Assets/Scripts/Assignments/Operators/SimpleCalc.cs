using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{
    public int NumberA = 10;
    public int NumberB = 7;
    public int NumberC = 33;
// floats must have f after number
    public float NumberD = 7f;
    public float NumberE = 33f;

    // Start is called before the first frame update
    void Start()
    {
        Add();
        Sub();
        Multy();
        Div();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Add()
    {
        int total;
        total = NumberA + NumberB;

        Debug.Log(NumberA +" + "+ NumberB +"="+ total);
    }
    void Sub()
    {
        int total;
        total = NumberB - NumberC;

        Debug.Log(NumberB +" - "+ NumberC +"="+ total);
    }
    void Multy()
    {
        int total;
        total = NumberA * NumberB;

        Debug.Log(NumberA +" * "+ NumberB +"="+ total);

    }
    void Div()
    {
        int total;
        int rem;

        float tot;

        total = NumberC / NumberB;
        rem = NumberB % NumberC;

        tot = NumberD / NumberE;

        Debug.Log (NumberB +"/"+ NumberC +"="+ total);
        Debug.Log ("Remainder ="+ rem);

        Debug.Log (NumberE +"/"+ NumberD +"="+ tot);
        Debug.Log ("Remainder ="+ rem);
    }
}