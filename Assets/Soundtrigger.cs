using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrigger : MonoBehaviour
{
    // Start is called before the first frame update
      // Reference to the AudioSource component
    public AudioSource audioSource;

    // This method is called when another object enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the audio is not already playing
        if (!audioSource.isPlaying)
        {
            // Play the audio
            audioSource.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Check if the audio is not already playing
        if (audioSource.isPlaying)
        {
            // Play the audio
            audioSource.Stop();
        }
    }
}
