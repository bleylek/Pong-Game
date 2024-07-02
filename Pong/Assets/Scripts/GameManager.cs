using UnityEngine.UI;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private int pScore;
    private int cScore;
    public Text pScoreText;
    public Text cScoreText;
    public Ball ball;
    public Paddle computerPadddle;
    public Paddle playerPaddle;

    public void ScoresfPlayer()
    {
        pScore++;
        this.pScoreText.text = pScore.ToString();
        Debug.Log(pScore);
        GenReset();
    }

    public void ScoresfComputer()
    {
        cScore++;
        this.cScoreText.text = cScore.ToString();
        Debug.Log(cScore);
        GenReset();
    }

    private void GenReset()
    {
        this.playerPaddle.resetPosition();
        this.computerPadddle.resetPosition();
        this.ball.resPos();
        this.ball.StartingForce();
        
    }
    

}
