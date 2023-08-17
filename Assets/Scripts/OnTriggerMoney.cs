using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerMoney : MonoBehaviour
{
    public Animator anim;
    public BoxCollider2D boxCollider;
    

    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(collider.tag == "Bullet")
        {
              var controlled = GetComponent<Enemy1Movement>();
              controlled.controlledspeed = 0f;
              Destroy(gameObject , 0.42f);
              boxCollider.enabled = false;

              anim.SetBool("isDead", true);
              MoneyScript.moneyValue += 75 * MoneyScript.moneyCoeffecient;
              
        }

        if(collider.tag == "Wall")
        {
              var controlled = GetComponent<Enemy1Movement>();
              controlled.controlledspeed = 0f;
              anim.SetBool("isAttack", true);
              InvokeRepeating("SesCal", 0.125f, 0.73f);
              InvokeRepeating("CanAzalt", 0.0f, 0.4f);
        }

        
        
    }
    void CanAzalt()
    {
       HealthScript.HealthBar.fillAmount -= 1/MoneyScript.healthValue2;
       MoneyScript.healthValue -= 1;
    }

    void SesCal()
    {
       Enemy1Audio.audioSource.Play();
    }
}
