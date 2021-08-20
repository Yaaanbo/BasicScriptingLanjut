using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4Karakter
{
    private string name;
    private int health;
    private int damage;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    public void moveLeft()
    {
        Debug.Log("Gerak ke kiri");
    }
    public void moveRight()
    {
        Debug.Log("Gerak ke kanan");
    }
    public void jump()
    {
        Debug.Log("Loncat");
    }
    public void attack()
    {
        Debug.Log("Serang");
    }
}
