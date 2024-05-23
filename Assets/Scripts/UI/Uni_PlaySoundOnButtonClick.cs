using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uni_PlaySoundOnButtonClick : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip hoverSound;
    [SerializeField] private AudioClip clickSound;

    public void playHoverSound()
    {
        if (hoverSound != null) { audioSource.PlayOneShot(hoverSound); }
    }

    public void playClickSound()
    {
        if (clickSound != null) { audioSource.PlayOneShot(clickSound); }
    }
}
