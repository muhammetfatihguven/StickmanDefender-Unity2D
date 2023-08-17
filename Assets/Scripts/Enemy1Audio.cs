using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Audio : MonoBehaviour
{
    public static AudioSource audioSource;
    void Start()
    {
         audioSource = GetComponent<AudioSource>();
    }

}
