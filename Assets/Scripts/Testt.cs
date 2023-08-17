using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position * -1;
        
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y , difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + 1);
        
    }

    
}
