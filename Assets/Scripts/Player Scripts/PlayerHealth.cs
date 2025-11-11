using Unity.VisualScripting.Antlr3.Runtime;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int CurrentHealth;
    public TextMeshProUGUI HealthText;

    void Start()
    {
        CurrentHealth = MaxHealth; //Sets the players health to max
    }

    public void ArrowHit(int Damage)
    {
        CurrentHealth -= Damage;  //Take Damage

        if(CurrentHealth <= 0)
        {
            Failed();  //load the function that takes you to the fail screen
        }
    }
    void Failed()
    {
        SceneManager.LoadScene(2);
    }

    void Update()
    {
        HealthText.text = System.Convert.ToString("Health: " + CurrentHealth);
    }
}
