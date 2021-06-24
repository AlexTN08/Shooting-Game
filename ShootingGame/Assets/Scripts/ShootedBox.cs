using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootedBox : MonoBehaviour
{
    //The box's current health point total
    private int currentHealth = 1;

    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;

        //Check if health has fallen below zero
        if (currentHealth <= 0)
        {
            //if health has fallen below zero, destroy it 
            Destroy(gameObject);
        }
    }
}