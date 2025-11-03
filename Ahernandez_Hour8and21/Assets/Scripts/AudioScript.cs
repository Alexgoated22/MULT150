using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Check for 'Z' key instead of Jump
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleAudio();
        }
    }

    // Optional extra credit (cleaner Update)
    void ToggleAudio()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
        else
            audioSource.Play();
    }
}