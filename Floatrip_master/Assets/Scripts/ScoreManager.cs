using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{

    public int[] Score = new int[3];// スコアたち

    public int result;// プレイヤーから引っ張ってきたScoreをfloatにして保存する変数

    // 各スコアを呼び出すためのパス
    string first;
    string second;
    string third;

    // Use this for initialization
    void Start()
    {
        // 保存したスコアを取得
        Score[0] = PlayerPrefs.GetInt(first);
        Score[1] = PlayerPrefs.GetInt(second);
        Score[2] = PlayerPrefs.GetInt(third);

        result = (int)Player.Score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // スコアの並び替えと保存
    public void ScoreSort()
    {
        if (Score[0] < result)
        {
            Score[2] = Score[1];
            Score[1] = Score[0];
            Score[0] = result;
        }

        else if (Score[1] <= result)
        {
            Score[2] = Score[1];
            Score[1] = result;
        }

        else if (Score[2] <= result)
        {
            Score[2] = result;
        }

        // スコアの保存
        PlayerPrefs.SetInt(first, Score[0]);
        PlayerPrefs.SetInt(second, Score[1]);
        PlayerPrefs.SetInt(third, Score[2]);

    }
}