using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    //0～9
    [SerializeField]
    private Sprite[] sprites = new Sprite[10];

    private Image image;
    private ScoreManager sm;

    // Use this for initialization
    void Start()
    {
        this.image = this.GetComponent<Image>();
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // スコアの表示
    public void OnScoreBoard(int signal)
    {
        // scoreValueの
        int a = signal / 10;
        int b = signal % 10;

        int num;

        int s = sm.Score[a];

        print(s + ":" + a);

        switch (b)
        {
            case 0:
                num = s / 100;
                this.image.sprite = this.sprites[num];
                break;
            case 1:
                num = (s % 100) / 10;
                this.image.sprite = this.sprites[num];
                break;
            case 2:
                num = s % 10;
                this.image.sprite = this.sprites[num];
                break;
        }
    }

    public void OnResultBoad()
    {
        int reScore = (int)Player.Score;

        int c = reScore / 100;       // 百の位
        int d = (reScore % 100) / 10;// 十の位
        int e = reScore % 10;        // 一の位

        // 各位の数字を表示(this.nameはこのスクリプトが取り付けられたGameObjectの名前です)
        switch (this.name)
        {
            case "h":
                this.image.sprite = this.sprites[c];
                break;
            case "t":
                this.image.sprite = this.sprites[d];
                break;
            case "o":
                this.image.sprite = this.sprites[e];
                break;

        }

        /*if (reScore > sm.Score[2])
        {
            //あらかじめNew!を置いておいて、条件を満たしたらenabledにする
        }*/



    }
}
