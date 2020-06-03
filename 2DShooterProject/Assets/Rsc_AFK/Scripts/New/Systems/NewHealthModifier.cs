using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHealthModifier : MonoBehaviour
{
    public bool destroyWhenActivated = false;
    public int amount = 0;
    public NewHealthSystem NewHealthSystem;
    public GameObject interact;
    private int collisionCount;
    public int HPofObject;

    // This function gets called everytime this object collides with another
    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        OnTriggerEnter2D(collisionData.collider);
    }

    private void OnTriggerEnter2D(Collider2D colliderData)
    {
        if (amount < 0) // if the amount of health change is less than 0, damage.
        {
            NewHealthSystem.Damage(amount);
            amount = 0;
        }
        else // if the amount of health change is more than 0, heal.
        {
            NewHealthSystem.Heal(amount);
            amount = 0;
        }
        if (destroyWhenActivated == true)
        {
            Destroy(this.interact);
        }
    }
}
