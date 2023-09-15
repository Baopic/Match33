using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanelController : MonoBehaviour
{
    public Animator loseAnim;
    public Animator panelAnim;
    public Animator gameInfoAnim;
    public EndGameManager endGameManager;
    public void OK()
    {
        if (loseAnim != null)
        {
            gameObject.SetActive(false);
            StartCoroutine(GameStartCo());
            loseAnim.SetBool("Out", true);
            panelAnim.SetBool("Out", false);
            gameInfoAnim.SetBool("Out", false);
        }
        
        IEnumerator GameStartCo()
        {
            yield return new WaitForSeconds(1f);
            Board board = FindObjectOfType<Board>();
            board.currentState = GameState.move;

        }
    }
}
