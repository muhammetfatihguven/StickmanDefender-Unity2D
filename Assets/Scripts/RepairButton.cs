using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepairButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(MoneyScript.healthValue2 - MoneyScript.healthValue < 1)
        {
            GetComponent<Button>().interactable = false;
        }
        else 
        {
           if(MoneyScript.moneyValue < 2500)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }
        }
        

    }
}
