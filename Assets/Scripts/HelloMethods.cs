
using UnityEngine;

// How to: Methoden


public class HelloMethods : MonoBehaviour
{
    //1 Instanzvariable ändern
    //2 return Rückgabewert haben
    // für 5) return --> Vorschlag für 5 GetDifference() - mit strg+R umbenennen 

    //2) Instanzvariable nutzen
    private int startValue2 = 0;

    //3) Der Wert der dazugezählt wird ist bei Deklaration noch nicht bekannt
    // z.B: Random oder User Input

    private int startValue3 = 0;
    private int startValue4 = 10;
    private int startValue5 = 20;
    
    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        //at 2) Instanzvariable nutzen
        Debug.Log("before startValue: " + startValue2);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue2);

        //at 3)
        Debug.Log("before startValue3: " + startValue3);
        IncrementByX(Random.Range(1,10));
        Debug.Log("after startValue3: " + startValue3);

        //at 4)
        Debug.Log("before startValue4: " + startValue4);
        OutputDecrementedValue(startValue4);
        Debug.Log("after startValue4: " + startValue4);

        //at 5)
        Debug.Log("before startValue5: " + startValue5);
        startValue5 = GetDifference(startValue5, 2);
        Debug.Log("after startValue5: " + startValue5);
    }

   


    //3)
    private void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }



    //4)
    private void OutputDecrementedValue(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    //5) incl. return value
    private int GetDifference(int a, int b)
    {
        return a - b;
    }


    private void IncrementByOne()
    {
        startValue2++;
        //startValue = startValue +1;
    }

}
