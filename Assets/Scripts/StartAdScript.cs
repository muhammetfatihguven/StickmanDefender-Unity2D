using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAdScript : MonoBehaviour
{
    void Start()
    {
       Invoke("RunAfterDelay", 0.80f);
    }

    void RunAfterDelay()
    {
        NewAdMobScript.GecisReklamiGoster();
    }
}
