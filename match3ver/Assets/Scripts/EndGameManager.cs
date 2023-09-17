using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class EndGameManager : MonoBehaviour
{
    public TMP_Text counter;
    public int currentCounterValue;
    public int counterValue;
    private float timerSeconds;
    private Board board;
    public GameObject loseMenu;
    public bool startMenu;
    void Start()
    {
        board = FindObjectOfType<Board>();
        SetupGame();
        startMenu = true;
    }
    void SetupGame()
    {
        currentCounterValue = counterValue;
        timerSeconds = 1;
        counter.text = "" + currentCounterValue;
    }
    
    public void DecreaseCounterValue()
    {
        if (startMenu == false)
        {
            currentCounterValue--;
            counter.text = "" + currentCounterValue;
            if (currentCounterValue <= 0)
            {
                board.currentState = GameState.lose;
                Debug.Log("You lose!");
                currentCounterValue = 0;
                counter.text = "" + currentCounterValue;
                ShowObject();
            }
        }
        
    }
    void Update()
    {
        timerSeconds -= Time.deltaTime;
        if (timerSeconds <= 0)
        {
            DecreaseCounterValue();
            timerSeconds = 1;
        }
    }
    void ShowObject()
    {
        loseMenu.SetActive(true);
    }

}
