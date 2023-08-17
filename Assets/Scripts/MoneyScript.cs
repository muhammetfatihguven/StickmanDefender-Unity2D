using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class MoneyScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public static float moneyValue = 0;
    public TextMeshProUGUI asd;
    public static int waveValue = 1;
    public TextMeshProUGUI BulletText;
    public static float bulletValue = 6;
    public static float bulletValue2 = 6f;
    public TextMeshProUGUI HealthText;
    public static float healthValue = 500f;
    public static float healthValue2 = 500f;

    public static float reloadspeed = 2.9f;
    public static float reloadfill = 0.0029f;
    public static float reloadspeedv2 = 0.00205f;

    public static int moneyCoeffecient = 1;

    public static int smart = 5;

    public GameObject Canvas;




    IEnumerator ExecuteAfterTime(float time)
 {
     yield return new WaitForSeconds(time);
 
    
 }  

    void Reload()
    {
        bulletValue = bulletValue2;
    }

    void Fill()
    {
        bulletBarScript.BulletBar.fillAmount += reloadspeedv2;
    }
    
    void Delay()
    {
        smart = 5;
    }
    
    
    void Update()
    {
        if (bulletValue == 0)
        {
             if(smart == 5)
            {
                
           ReloadAudioScript.audioSource.Play();
           
           bulletValue = 0;
           Invoke("Reload", reloadspeed);
           bulletBarScript.BulletBar.fillAmount = 0f;
           InvokeRepeating("Fill", 0.01f,reloadfill);
           smart = 0;
           Invoke ("Delay", reloadspeed);
               // }
           
            }
        }
        Text.text = "" + moneyValue;
        asd.text = "Wave " + waveValue + "/10";
        BulletText.text = "" + bulletValue + "/" + bulletValue2;       
        HealthText.text = "" + healthValue + "/" + healthValue2;


      if(bulletBarScript.BulletBar.fillAmount == 1f)
      {
         CancelInvoke("Fill");
         
      }
      

      if(healthValue < 0f)
      {
        Time.timeScale = 0f;
        healthValue = 0f;
        Canvas.SetActive(true);

      }
    
    }
}
