using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentSceneIndex;

    private void Start()
    {
        FindObjectOfType<MusicPlayer>().GetComponent<MusicPlayer>().MusicPlay();
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
