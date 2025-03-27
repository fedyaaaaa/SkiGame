using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;

    private void OnEnable()
    {
        PlayerEvents.OnHitEvent += PlayHitSound;
    }
    private void OnDisable()
    {
        PlayerEvents.OnHitEvent -= PlayHitSound;
    }
    private void PlayHitSound()
    {
        source.PlayOneShot(clip);
    }
}
