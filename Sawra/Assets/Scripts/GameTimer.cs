using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float gameTimePerMin = 30f;
    [SerializeField] float currentTimer;
    [SerializeField] float barTimer;
    [SerializeField] Image barImage;
    Animator anim;
    bool endGame = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTimer = 0 ;
        barTimer = 0;
        anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!endGame)  BarFill();
    }

    void BarFill()
    {
        currentTimer += Time.deltaTime;
        barTimer = Mathf.Clamp(currentTimer, 0, gameTimePerMin);
        barImage.fillAmount = barTimer / gameTimePerMin;

        if (barTimer >= gameTimePerMin)
        {
            endGame = true;
            anim.SetTrigger("GameEnd");
            FindObjectOfType<MusicPlayer>().PlayGameOver();
        }
    }

    public bool EndGame()
    {
        return endGame;
    }
}
