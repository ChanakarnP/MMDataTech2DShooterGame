using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
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
        Player.AlterScore(amount);

        if (destroyWhenActivated == true)
        {
            Destroy(this.interact);
        }
    }
}
