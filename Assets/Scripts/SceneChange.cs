using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    public void ChangeScene() {
        Debug.Log("Buttons clicked");
        SceneManager.LoadScene("Zombies");
    }
}