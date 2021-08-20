using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour
{
    // Start is called before the first frame update
    int jumlah(int a, int b)
    {
        return a + b;
    }
    void Start()
    {
        int c = jumlah(60, 40);
        Debug.Log($"A + B = {c}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
