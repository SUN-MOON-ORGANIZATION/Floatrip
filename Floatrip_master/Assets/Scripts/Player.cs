using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    [SerializeField]
    private float speed;
    Touch touch0,touch1;
    Vector3 touchPos;
    Vector3 screenPos;
    private float difference;
    private float after;
    [SerializeField]
    private float xUpLimit, yUpLimit;
    [SerializeField]
    private float xDownLimit, yDownLimit;
    public static float Score;
    public float ScorePlus,Variation;//足される値
    SphereCollider sphere;
    // Use this for initialization
    void Start () {
        Score = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        //左クリックでScoreに足される値加速
        if (Input.GetMouseButton(0))
        {
            ScorePlus += Variation;
            Score += ScorePlus;
        }
        //右クリックでScoreに足される値減速
        if (Input.GetMouseButton(1) && ScorePlus > 0)
        {
            ScorePlus -= Variation;
            Score += ScorePlus;
        }
        Move();
        Scalling();
        ScoreCount();
    }
    //左右移動
    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            screenPos = Input.mousePosition;
            screenPos.z = -10f;
            touchPos = Camera.main.ScreenToWorldPoint(screenPos);
            touchPos.y = this.transform.position.y;
            touchPos.z = this.transform.position.z;
            //touchPos.x = -touchPos.x;
            this.transform.position = Vector3.Lerp(this.transform.position, touchPos, speed * Time.deltaTime);
        }
        if(Input.touchCount == 1)
        {
            touch0 = Input.GetTouch(0);
            touchPos = touch0.position;
            touchPos.z = -10f;
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);
            touchPos.y = this.transform.position.y;
            touchPos.z = this.transform.position.z;
            touchPos.x = -touchPos.x;
            this.transform.position = Vector3.Lerp(this.transform.position, touchPos, speed * Time.deltaTime);
        }
    }
    //サイズ変更
    void Scalling()
    {
        if(Input.touchCount == 2)
        {
            touch0 = Input.GetTouch(0);
            touch1 = Input.GetTouch(1);
            if(touch0.phase == TouchPhase.Began && touch1.phase == TouchPhase.Began) difference = Mathf.Abs(touch0.position.y - touch1.position.y);
            after = Mathf.Abs(touch0.position.y - touch1.position.y);
            if (difference < after && this.transform.localScale.x < xUpLimit && this.transform.localScale.y < yUpLimit)
            {
                this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                ScorePlus += Variation;
            }
                
            if (difference > after && this.transform.localScale.x > xDownLimit && this.transform.localScale.y > yDownLimit)
            {
                this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                ScorePlus -= Variation;
            }
            difference = Mathf.Abs(touch0.position.y - touch1.position.y);
        }
    }
    //スコア加算
    void ScoreCount()
    {
        //スコアの値が-にならないように
        if (ScorePlus <= 0)
        {
            ScorePlus = Variation;
        }
        Score += ScorePlus;
    }
    void GameOver()
    {

    }
}
 