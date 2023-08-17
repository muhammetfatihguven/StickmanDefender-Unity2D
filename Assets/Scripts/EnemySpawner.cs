using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float minimum = -2.75F;
    public float maximum =  1.5F;
    public float lerpValue;
    public float randomYer;
    
    
    void Start()
    {
        InvokeRepeating("RandomYer", 1.0f, 0.15f);
    }

    void RandomYer()
    {
        float randomYer = Random.Range(0f, 1f);
        lerpValue = Mathf.Lerp(minimum, maximum , randomYer);
        transform.position = new Vector3(-9, lerpValue, 0);
    }
}
