using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prajurit : Manusia
{

    void Start()
    {
        Debug.Log("Seorang prajurit dapat: ");
        Makan();
        Tidur();
        Menyerang();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Menyerang()
    {
        Debug.Log("Attack");
    }
}
