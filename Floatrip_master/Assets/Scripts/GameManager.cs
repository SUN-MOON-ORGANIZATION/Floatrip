using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//列挙型ゲームステート
public enum GameState
{
    TITLE = 0,
    INSTRUCTION,
    SCORE,
    PLAY,
    PAUSE,
    RESULT
};

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //ゲームステート
    private static GameState gameState;

    //Canvasたち
    public Canvas canvasTitle;
    public Canvas canvasInstruction;
    public Canvas canvasScore;
    public Canvas canvasPlay;
    public Canvas canvasPause;
    public Canvas canvasResult;

    //プロパティ
    public static GameState GameStateProp
    {
        get
        {
            return gameState;
        }
        set
        {
            gameState = value;
        }
    }

    //GameManagerをDontDestroyする
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = GameObject.Find("GameManager").GetComponent<GameManager>();
        DontDestroyOnLoad(gameObject);

    }

    //Title画面の初期設定
    void Start()
    {
        gameState = GameState.TITLE;

        canvasTitle.enabled = true;
    }

    //canvasの切り替え
    public void ShiftCanvas()
    {
        switch (GameManager.GameStateProp)
        {
            //タイトルはcanvasTitleのみtrue
            case GameState.TITLE:
                canvasTitle.enabled = true;
                canvasInstruction.enabled = false;
                canvasScore.enabled = false;
                break;
            //同じくインストラクション
            case GameState.INSTRUCTION:
                canvasTitle.enabled = false;
                canvasInstruction.enabled = true;
                canvasScore.enabled = false;
                break;
            //同じく
            case GameState.SCORE:
                canvasTitle.enabled = false;
                canvasInstruction.enabled = false;
                canvasScore.enabled = true;
                break;
            //同じ
            case GameState.PLAY:
                canvasPlay.enabled = true;
                canvasPause.enabled = false;
                canvasResult.enabled = false;
                break;
            //同
            case GameState.PAUSE:
                canvasPlay.enabled = false;
                canvasPause.enabled = true;
                canvasResult.enabled = false;
                break;
            //同
            case GameState.RESULT:
                canvasPlay.enabled = false;
                canvasPause.enabled = false;
                canvasResult.enabled = true;
                break;
            //何も表示しない
            default:
                canvasTitle.enabled = false;
                canvasInstruction.enabled = false;
                canvasScore.enabled = false;
                canvasPlay.enabled = false;
                canvasPause.enabled = false;
                canvasResult.enabled = false;
                break;
        }
    }

}