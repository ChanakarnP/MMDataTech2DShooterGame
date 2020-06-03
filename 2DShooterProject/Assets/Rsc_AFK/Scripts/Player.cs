using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int StartHealth = 10;
    public Text CurrentHealthLabel;
    private int CurrentHealth;
    private int LimitHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = StartHealth;
        UpdateHealthGUI();   
    }
    
    void UpdateHealthGUI()
    {
        CurrentHealthLabel.text = CurrentHealth.ToString();
    }

    public void Damage(int damageAmount)
    {
        CurrentHealth += damageAmount;
        if(CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
        UpdateHealthGUI();
    }

    public void Heal(int healAmount)
    {
        CurrentHealth += healAmount;
        if (CurrentHealth > LimitHealth)
        {
            CurrentHealth = LimitHealth;
        }
        UpdateHealthGUI();
    }

    public int GetHP()
    {
        return CurrentHealth;
    }

    public void GameOver()
    {
        if(CurrentHealth <= 0)
        { 
            SceneManager.LoadScene("GameOver");
        }
       
    }



    //-----------------End of Health--------------------------------//

    //-----------------Start of Score-------------------------------//

    private int Score;
    public Text CurrentScoreLabel;

    void UpdateScoreGUI()
    {
        CurrentScoreLabel.text = Score.ToString();
    }

    public void AlterScore(int ScoreAmount)
    {
        Score += ScoreAmount;
        UpdateScoreGUI();
    }

    //-----------------End of Score-------------------------------//



}
