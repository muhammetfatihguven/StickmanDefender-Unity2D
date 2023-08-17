using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    public float controlledspeed = 1.4f;
    public GameObject Enemy2;
    public Animator anim;
    public int gunmanhealth = 2;
    public static int bulletStrength = 1;
    


    void Start()
    {
        anim = GetComponent<Animator>();
        
        
    }

    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += controlledspeed * Time.deltaTime;
        Enemy2.transform.position = temp;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(collider.tag == "GunStop")
        {
              controlledspeed = 0.0f;
              anim.SetBool("isStop", true);
              InvokeRepeating("CanAzalt", 0.0f, 0.4f);
        }

        if(collider.tag == "Bullet")
        {  

            gunmanhealth -= bulletStrength;

            if(gunmanhealth == 0)
            {
                  Destroy(gameObject);
                  
                  MoneyScript.moneyValue += 275 * MoneyScript.moneyCoeffecient;
            }
              
              
              
              
              
              
        }
        
    }

  

    void CanAzalt()
    {
       HealthScript.HealthBar.fillAmount -= 2/MoneyScript.healthValue2;
       MoneyScript.healthValue -= 2;
    }
}
