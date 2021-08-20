using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour
{
    /*int[] intArray;//deklarasi array
    // Start is called before the first frame update
    void Start()
    {
        intArray = new int[4]; //inisialisasi Array
        intArray[0] = 10;
        intArray[1] = 20;
        intArray[2] = 30;
        intArray[3] = 40;
        Debug.Log("Menampilkan seluruh Array");
        foreach (int a in intArray)
        {
            Debug.Log(a);
        }
        Debug.Log($"Nilai index kedua adalah {intArray[2]}");
    }*/

    public int[] intArray;//deklarasi array
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Menampilkan seluruh Array");
        foreach (int a in intArray)
        {
            Debug.Log(a);
        }
        Debug.Log($"Nilai index kedua adalah {intArray[2]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
