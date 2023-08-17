using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    
    public GameObject bullet;
    public GameObject FirePoint;
    


    // Update is called once per frame
    void Update()
    {
        if(MoneyScript.bulletValue > 0)
        {
              if(Input.GetMouseButtonDown(0))
        {
           
           GameObject bullett = Instantiate(bullet, new Vector3(FirePoint.transform.position.x,
           FirePoint.transform.position.y, 0), Quaternion.identity);
           MoneyScript.bulletValue -= 1;
           bullett.name = "Bullet";
           FireAudioScript.audioSource.Play();

           bulletBarScript.BulletBar.fillAmount -= 1/MoneyScript.bulletValue2;

            


        }
        }
        
    }
}


