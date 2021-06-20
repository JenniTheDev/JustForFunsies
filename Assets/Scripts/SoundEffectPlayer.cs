using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour {
    [SerializeField] private AudioSource audioPlayer;
    [SerializeField] private AudioClip soundToPlay;

    public void PlaySoundEffect() {
        audioPlayer.clip = soundToPlay;
        audioPlayer.Play();
    }
}