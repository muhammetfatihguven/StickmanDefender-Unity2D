using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sunMoveScript : MonoBehaviour
{
    
    public static float controlledspeed = 0.0999f;
    public GameObject Sun;

    void Update()
    {
        Vector3 temp = transform.position;
        temp.x += controlledspeed * Time.deltaTime;
        Sun.transform.position = temp;

        
        
    }

    
}
