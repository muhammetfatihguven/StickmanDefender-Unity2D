using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strengthbtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoneyScript.moneyValue < 15000f)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            if (Enemy2Script.bulletStrength == 2)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }
            
        }

        if (Enemy2Script.bulletStrength == 2)
        {
            GetComponent<Button>().interactable = false;
        }
        
    }
}
