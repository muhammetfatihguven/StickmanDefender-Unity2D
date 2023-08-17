using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float speed = 50f;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        Destroy (gameObject, 1.76f);
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right *  speed);
    }
}
