using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanAudioScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClip;

    public void OnImage()
    {
        audioSource.PlayOneShot(audioClip[Random.Range(0, audioClip.Length)]);
    }

    public void StopSound()
    {
        audioSource.Stop();
    }
}
