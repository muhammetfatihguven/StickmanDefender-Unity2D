using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public static Image HealthBar;
    
    private void Start()
    {
        HealthBar = GetComponent<Image>();
        HealthBar.fillAmount += MoneyScript.healthValue/MoneyScript.healthValue2;
    }

    // Update is called once per frame
    public static void Enemy1Attacked()
    {
        HealthBar.fillAmount -= MoneyScript.healthValue/MoneyScript.healthValue2;
    }
}
