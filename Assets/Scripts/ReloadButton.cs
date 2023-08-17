using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadButton : MonoBehaviour
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
            if(MoneyScript.reloadspeedv2 == 0.00410f)
        {
            GetComponent<Button>().interactable = false;
        }
        else 
        {
            GetComponent<Button>().interactable = true;
        }
            
        }
        
        if(MoneyScript.reloadspeedv2 == 0.00410f)
        {
            GetComponent<Button>().interactable = false;
        }

    }
}
