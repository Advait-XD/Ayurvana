using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videotrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // This method is called when another object enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the player tag (or any tag you define)
        
            // Start playing the video
            videoPlayer.Play();
        
    }

    // This method is called when another object exits the trigger collider
    private void OnTriggerExit(Collider other)
    {
        // Check if the object leaving the trigger has the player tag
       
        
            // Stop the video
            videoPlayer.Stop();
        
    }

}
