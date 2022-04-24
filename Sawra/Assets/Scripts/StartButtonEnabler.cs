using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonEnabler : MonoBehaviour
{
    [SerializeField] float startWaitTime = 1.5f;
    Button startButton;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        startButton = GetComponentInChildren<Button>();
        yield return new WaitForSeconds(startWaitTime);
        startButton.interactable = true;
    }

    public void LoadNextSceneAnim()
    {
        startButton.interactable = false;
        GetComponent<Animator>().SetTrigger("FadeOut");
    }

    public void LoadNextScene()
    {
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
