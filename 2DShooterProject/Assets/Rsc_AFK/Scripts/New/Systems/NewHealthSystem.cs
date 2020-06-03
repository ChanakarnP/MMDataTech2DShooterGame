using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHealthSystem : MonoBehaviour
{
    public int MaxHealth;
    public Text CurrentHealthLabel;
    private int CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        UpdateHealthGUI();
    }

    void UpdateHealthGUI()
    {
        CurrentHealthLabel.text = CurrentHealth.ToString();
    }

    public void Damage(int damageAmount)
    {
        CurrentHealth += damageAmount;
        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
        UpdateHealthGUI();
    }

    public void Heal(int healAmount)
    {
        CurrentHealth += healAmount;
        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
        UpdateHealthGUI();
    }

}
