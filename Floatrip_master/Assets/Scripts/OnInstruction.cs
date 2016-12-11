using UnityEngine;
using System.Collections;

public class OnInstruction : MonoBehaviour
{
    //Canvas
    public Canvas canvasInstruction;

    public static GameManager gm;

    //プロパティ
    public static OnInstruction onInstruction
    {
        get
        {
            return onInstruction;
        }
        set
        {
            onInstruction = value;
        }
    }

    public GameObject g;

    void OnDisplay()
    {
        //INSTRUCTIONに移行したら、オブジェクトを表示
        if (GameManager.GameStateProp == GameState.INSTRUCTION)
        {
            g = GameObject.Find("balloon1");
            Instantiate(g);
            Animation floatBalloon = gameObject.GetComponent<Animation>();
        }
    }

    void BackTitle()
    {
        //タッチするとタイトルへ戻る
        if (Input.touchCount > 0)
        {
            Animation anim2 = gameObject.GetComponent<Animation>();
            Destroy(g);
        }
    }
}
