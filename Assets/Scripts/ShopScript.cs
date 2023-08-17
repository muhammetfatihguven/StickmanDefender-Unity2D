using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour
{
   

    

     public static void OnInterstitalAdSuccess2()
     {
        Debug.Log("Odullu Reklam Basarili");
        adbtnscript.reklamsayaci += 1;
        MoneyScript.moneyValue += 2500;
     }
     

    
    public void Continue()
    {
        if(MoneyScript.waveValue < 9)
        {
            SceneManager.LoadScene("Main Scene");
            MoneyScript.waveValue += 1;
            MoneyScript.bulletValue = MoneyScript.bulletValue2;
            MoneyScript.smart = 5;
            adbtnscript.reklamsayaci -= 1;
        }
        else if (MoneyScript.waveValue == 9)
        {
            SceneManager.LoadScene("LastWave");
            MoneyScript.waveValue += 1;
            MoneyScript.bulletValue = MoneyScript.bulletValue2;
            MoneyScript.smart = 5;
            adbtnscript.reklamsayaci -= 1;
        }
        
        
        
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("StartScene");
        MoneyScript.moneyValue = 0;
        MoneyScript.bulletValue = 6;
        MoneyScript.bulletValue2 = 6;
        MoneyScript.healthValue = 500f;
        MoneyScript.healthValue2 = 500f;
        MoneyScript.moneyCoeffecient = 1;
        OnTriggerDestroy.piercepower = 1;
        OnTriggerDestroy.piercereload = 1;
        Enemy2Script.bulletStrength = 1;
        MoneyScript.reloadspeedv2 = 0.00205f;
        MoneyScript.reloadspeed = 2.9f;
       
    }

    public void QuitGame()
    {
        string url = "https://mamistagames.blogspot.com/2022/12/privacy-policy.html";
        Application.OpenURL(url);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main Scene");
        MoneyScript.waveValue = 1;
        MoneyScript.reloadfill = 0.0029f;
        Time.timeScale = 1f;
    }

    public void UpgradeBullet()
    {
        MoneyScript.bulletValue += 1f;
        MoneyScript.bulletValue2 += 1f;
        MoneyScript.moneyValue -= 2000;

    }

    public void RepairWall()
    {
        MoneyScript.healthValue += 150f;
        
        MoneyScript.moneyValue -= 2500f;

        if(MoneyScript.healthValue > MoneyScript.healthValue2)
        {
            MoneyScript.healthValue = MoneyScript.healthValue2;
        }
    }

    public void UpgradeWall()
    {
        MoneyScript.healthValue = 1000f;
        MoneyScript.healthValue2 = 1000f;
        
        MoneyScript.moneyValue -= 10000f;
    }

    public void ReloadUpgrade()
    {
        MoneyScript.reloadspeed = 1.4f;
        bulletBarScript.reloadfillv2 = 0.115f;
        MoneyScript.reloadspeedv2 = 0.00410f;

        MoneyScript.moneyValue -= 15000f;
    }

    public void StrengthUpgrade()
    {
        OnTriggerDestroy.piercepower = 2;
        OnTriggerDestroy.piercereload = 2;
        Enemy2Script.bulletStrength = 2;

        MoneyScript.moneyValue -= 15000f;
    }

    public void DoubleMoney()
    {
        MoneyScript.moneyCoeffecient = 3;

        MoneyScript.moneyValue -= 20000f;
    }

    public void OdulluReklam()
    {
       
        
    }
    void RewardedAdWorked()
    {
        Debug.Log("Odullu Reklam Basarili");
        adbtnscript.reklamsayaci += 1;
        MoneyScript.moneyValue += 2500;
    }
}
