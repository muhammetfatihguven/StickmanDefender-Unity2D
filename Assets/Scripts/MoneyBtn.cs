using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(MoneyScript.moneyValue < 20000f)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            if (MoneyScript.moneyCoeffecient == 3)
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
