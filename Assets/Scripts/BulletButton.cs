using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletButton : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoneyScript.moneyValue < 2000)
        {
            GetComponent<Button>().interactable = false;
        }

        else
        {
            GetComponent<Button>().interactable = true;
        }
        
    }
}
