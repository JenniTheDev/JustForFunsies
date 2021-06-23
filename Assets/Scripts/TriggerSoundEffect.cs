using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundEffect : MonoBehaviour {
    [SerializeField] private AudioSource audioPlayer;
    [SerializeField] private AudioClip soundToPlay;

    public void OnTriggerEnter() {
        audioPlayer.clip = soundToPlay;
        audioPlayer.Play();
    }
}