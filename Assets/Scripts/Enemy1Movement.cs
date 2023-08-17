using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Movement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float controlledspeed = 2f;
    public GameObject Enemy1;

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += controlledspeed * Time.deltaTime;
        Enemy1.transform.position = temp;
    }

    
}
