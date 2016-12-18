using UnityEngine;
using System.Collections;

public class OnInstruction : MonoBehaviour
{
    //Canvas
    public Canvas canvasInstruction;
    public Canvas canvasInstruction2;
    public Canvas canvasInstruction3;

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
        if (Input.touchCount > 0)
        {
            //タッチすると次のページへ移動
            canvasInstruction2.enabled = true;

            if (Input.touchCount > 0)
            {
                //タッチすると次のページへ移動
                canvasInstruction2.enabled = true;

                //タッチするとタイトルへ戻る
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    Animation anim2 = gameObject.GetComponent<Animation>();
                    Destroy(g);
                }
            }
        }
    }
}
