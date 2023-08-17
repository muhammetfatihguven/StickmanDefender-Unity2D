using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneShopLoad : MonoBehaviour
{
    
    void OnTriggerEnter2D (Collider2D collider)
    {
        
        if(collider.tag == "Finish")
        {
            if(MoneyScript.waveValue < 10)
            {
                MoneyScript.smart = 5;
                SceneManager.LoadScene("Shop");
            }
              
              else
              {
              SceneManager.LoadScene("WinScreen");
              }
        }
        
    }
}
