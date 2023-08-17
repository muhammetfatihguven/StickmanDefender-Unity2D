using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class ShopTextHolder : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Text.text = "" + MoneyScript.bulletValue + "/" + MoneyScript.bulletValue2;
       Text2.text = "" + MoneyScript.moneyValue;
       Text3.text = "" + MoneyScript.healthValue + "/" + MoneyScript.healthValue2;

    }
}
