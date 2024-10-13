using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{
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
}