using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletBarScript : MonoBehaviour
{
    
    public static Image BulletBar;
    public static float reloadfillv2 = 0.0000f;
    
    void Start()
    {
        BulletBar = GetComponent<Image>();
    }

}
