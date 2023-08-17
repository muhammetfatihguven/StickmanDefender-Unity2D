using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadAudioScript : MonoBehaviour
{
    public static AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
}
