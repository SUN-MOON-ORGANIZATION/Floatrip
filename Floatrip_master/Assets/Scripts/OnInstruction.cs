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
        //Canvasが表示されたら、オブジェクトを表示
        /*if (GameManager.Instance.Canvas == canvasInstruction)
        {
            g = GameObject.Find("balloon1");
            Instantiate(g);
            Animation floatBalloon = gameObject.GetComponent<Animation>();
        }*/
    }

    void BackTitle()
    {
        //タッチするとタイトルへ戻る
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Animation anim2 = gameObject.GetComponent<Animation>();
                Destroy(g);
            }
        }
    }
}
