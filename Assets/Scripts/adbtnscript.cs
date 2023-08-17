using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class adbtnscript : MonoBehaviour
{
    public static int reklamsayaci = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(reklamsayaci > 0)
        {
            GetComponent<Button>().interactable = false;
        }
        else 
        {
            GetComponent<Button>().interactable = true;
        }
    }
}
