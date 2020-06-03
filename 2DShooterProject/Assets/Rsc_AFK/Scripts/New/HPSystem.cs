using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSystem : MonoBehaviour
{
    public int MaxHealth;
    private int CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        
    }

    public void Damage(int damageAmount)
    {
        CurrentHealth += damageAmount;
        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
        
    }

}
