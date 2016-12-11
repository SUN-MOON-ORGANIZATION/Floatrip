using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    GameManager gm;//GameManager

    string sceneName;//シーン名

    void Update()
    {
        //現在のステートを取得
        print(GameManager.GameStateProp);

        //GameManagerを取得
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        //現在のシーン名を取得
        sceneName = SceneManager.GetActiveScene().name;

        //メインシーンで必要なcanvasを取得
        if (sceneName == "Main")
        {
            gm.canvasPlay = GameObject.Find("CanvasPlay").GetComponent<Canvas>();
            gm.canvasPause = GameObject.Find("CanvasPause").GetComponent<Canvas>();
            gm.canvasResult = GameObject.Find("CanvasResult").GetComponent<Canvas>();
        }
        //タイトルシーンで必要なcanvasを取得
        if (sceneName == "Title")
        {
            gm.canvasTitle = GameObject.Find("CanvasTitle").GetComponent<Canvas>();
            gm.canvasInstruction = GameObject.Find("CanvasInstruction").GetComponent<Canvas>();
            gm.canvasScore = GameObject.Find("CanvasScore").GetComponent<Canvas>();
        }
    }

    //タイトルへ
    public void ToTitle()
    {
        //ポーズ、リザルトからタイトルへ
        if (GameManager.GameStateProp == GameState.PAUSE ||
            GameManager.GameStateProp == GameState.RESULT)
        {
            GameManager.GameStateProp = GameState.TITLE;
            SceneManager.LoadScene("Title");
        }
        //操作説明、スコア画面からタイトルへ
        else
        {
            GameManager.GameStateProp = GameState.TITLE;
            gm.ShiftCanvas();
        }
    }

    //説明画面を表示
    public void ToInstruction()
    {
        GameManager.GameStateProp = GameState.INSTRUCTION;
        gm.ShiftCanvas();
    }

    //スコア画面を表示
    public void ToScore()
    {
        GameManager.GameStateProp = GameState.SCORE;
        gm.ShiftCanvas();
    }

    //ポーズ画面を表示
    public void ToPause()
    {
        GameManager.GameStateProp = GameState.PAUSE;
        gm.ShiftCanvas();
    }

    //プレイ時のポーズボタンを表示
    public void ToPlay()
    {
        GameManager.GameStateProp = GameState.PLAY;
        gm.ShiftCanvas();
    }

    //ポーズ画面からプレイ画面に戻る
    public void BackPlay()
    {
        GameManager.GameStateProp = GameState.PLAY;
        gm.ShiftCanvas();
    }

    //リザルト画面を表示
    public void ToResult()
    {
        GameManager.GameStateProp = GameState.RESULT;
        gm.ShiftCanvas();
    }

    //プレイ画面にシーン遷移
    public void ToMain()
    {
        GameManager.GameStateProp = GameState.PLAY;
        SceneManager.LoadScene("Main");
    }

    //アプリを終了する
    public void OnExit()
    {
        Application.Quit();
    }
}
 