using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    

    public bool destroyWhenActivated = false;
    public int amount = 0;
    public Player Player;
    public GameObject interact;

    // This function gets called everytime this object collides with another
    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        OnTriggerEnter2D(collisionData.collider);
    }  

    private void OnTriggerEnter2D(Collider2D colliderData)
    {
        if (amount < 0) // if the amount of health change is less than 0, damage.
        {
            Player.Damage(amount);
            amount = 0;
        }
        else // if the amount of health change is more than 0, heal.
        {
            Player.Heal(amount);
            amount = 0;
        }
        if (destroyWhenActivated == true)
        {
            Destroy(this.interact);
        }

        if (Player.GetHP() <= 0)
        {
            Player.GameOver();

        }
        
    }

}
