using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public MeshRenderer playerMR;
    public PlayerController playerC;

    void Start()
    {
        health = maxHealth;
    }
public void TakeDamage(int amount)
    {
        health -= amount;
        if(health < 0)
        {
            playerMR.enabled = false;
            playerC.enabled = false;
        }
    }
}
