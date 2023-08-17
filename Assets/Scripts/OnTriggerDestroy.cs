using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDestroy : MonoBehaviour
{
    
public static int piercepower = 1;
public static int piercereload = 1;
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(collider.tag == "Enemy")
        {
            piercepower -= 1;

            if(piercepower == 0)
            {
                 Destroy(gameObject);
                 piercepower += piercereload;
            }
              
        }
        
    }
}
