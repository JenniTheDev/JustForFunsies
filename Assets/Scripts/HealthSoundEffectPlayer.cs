using SOEvents.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSoundEffectPlayer : MonoBehaviour {
    [SerializeField] private AudioSource audioPlayer;

    [SerializeField] private AudioClip[] playerGainHealthSounds;
    [SerializeField] private AudioClip[] playerLoseHealthSounds;
    [SerializeField] private GameEventHealthChange healthChangeEvent;

    public void PlaySoundEffect(HealthChangeData healthChangeAmt) {
        if (healthChangeAmt.ChangeAmount > 0) {
            int clipToPlay = Random.Range(0, playerGainHealthSounds.Length);
            audioPlayer.clip = playerGainHealthSounds[clipToPlay];
        } else if (healthChangeAmt.ChangeAmount < 0) {
            int clipToPlay = Random.Range(0, playerLoseHealthSounds.Length);
            audioPlayer.clip = playerLoseHealthSounds[clipToPlay];
        }
        audioPlayer.Play();
    }
}