using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan4 : MonoBehaviour
{
    L4Karakter player1;
    // Start is called before the first frame update
    void Start()
    {
        player1 = new L4Karakter();
        player1.Name = "Ryan";
        player1.Health = 150;
        player1.Damage = 50;
        //menampilkan hasil dari inisialisasi attribute
        Debug.Log($"Name: {player1.Name}, Health: {player1.Health}, Damage: {player1.Damage}");
        //memanggil method di kelas L4Karakter

        player1.jump();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
