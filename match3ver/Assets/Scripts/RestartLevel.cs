using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class RestartLevel : MonoBehaviour
{
    public Board board;
    public EndGameManager endGameManager;
    public ScoreManager scoreManager;
    public void Restart()
    {
        board = GetComponent<Board>();
        StartCoroutine(board.ShuffleBoard());
        board.currentState = GameState.move;
        endGameManager.currentCounterValue = endGameManager.counterValue;

    }
}
