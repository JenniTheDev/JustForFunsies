using SOEvents.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour {
    [SerializeField] private AudioSource audioPlayer;

    // [SerializeField] private AudioClip soundToPlay;
    [SerializeField] private GameEventHealthChange healthChangeEvent;

    public void PlaySoundEffect(GameEventHealthChange healthChangeEvent) {
        // audioPlayer.clip = healthChangeEvent.GameObject.GetComponent<AudioClip>();
        // audioPlayer.clip = soundToPlay;
        audioPlayer.Play();
    }
}