using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

    public GameObject lightBulb = null;
    public GameObject wall = null;
    public AudioClip lightbulbOn = null; // Contains/holds the audio clip
    public AudioSource lightBulbSource = null; // Controls the audio clip

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            // Turns the spotlight on
            lightBulb.SetActive(true);
            wall.GetComponent<ObjectScaling>().enableScale(); // Scales the wall
            wall.GetComponent<ObjectColor>().enableColor(); // Changes the wall's color

            // Plays an audio clip
            lightBulbSource.clip = lightbulbOn; // Assigns the AudioSource clip to the AudioClip
            lightBulbSource.PlayOneShot(lightbulbOn); // Plays the audio clip
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "player")
        {
            // Turns the spotlight off
            lightBulb.SetActive(false);
            wall.GetComponent<ObjectScaling>().disableScale();
            wall.GetComponent<ObjectColor>().disableColor();
            lightBulbSource.Stop(); // Stops the audio clip
            
        }
    }
}
