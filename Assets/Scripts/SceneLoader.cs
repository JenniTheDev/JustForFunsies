using System.Collections;
using System.Collections.Generic;
using SOEvents.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    [SerializeField] private GameEventDeath playerDeath;
    [SerializeField] private Animator transition;
    [SerializeField] private float transitionTime = 4f;

    public void PlayGameOverScene() {
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene() {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("GameOver");
    }
}