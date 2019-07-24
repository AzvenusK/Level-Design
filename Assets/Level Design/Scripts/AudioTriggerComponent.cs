using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerComponent : MonoBehaviour
{
    public AudioClip newAudio = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(newAudio);
        }
    }

 


}
