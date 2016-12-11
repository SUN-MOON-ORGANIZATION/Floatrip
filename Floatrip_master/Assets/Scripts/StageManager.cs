using UnityEngine;
using System.Collections;

public class StageManager : MonoBehaviour {
    public GameObject[] png = new GameObject[3];
    public GameObject Object;
    public float alpha;
    public float changeSpeed;
    public bool flag = true;
    public int count;
    public float crownPosy;
    private Vector3 crownPos;
    private Quaternion crownAngel = new Quaternion(0,0,180,0);
    public float time;
    public int b;
    // Use this for initialization
    void Start()
    {
        changeSpeed = 0.004f;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        
        if (time > b)
        {
            int a = Random.Range(0, 101);
            float crownPosx = 3 * (50 - a) / 50;
            crownPos = new Vector3(crownPosx,crownPosy,0);
            Instantiate(Object, crownPos, crownAngel);
            time = 0;
            b = Random.Range(3, 7);
        }
        if (alpha > 0 && count % 3 == 1)
        {
            alpha = alpha - changeSpeed;
            png[0].GetComponent<CanvasGroup>().alpha = alpha;
            png[1].GetComponent<CanvasGroup>().alpha = 1 - alpha;
        }

        if (alpha > 0 && count % 3 == 2)
        {
            alpha = alpha - changeSpeed;
            png[1].GetComponent<CanvasGroup>().alpha = alpha;
            png[2].GetComponent<CanvasGroup>().alpha = 1 - alpha;
        }

        if (alpha > 0 && count % 3 == 0)
        {
            alpha = alpha - changeSpeed;
            png[2].GetComponent<CanvasGroup>().alpha = alpha;
            png[0].GetComponent<CanvasGroup>().alpha = 1 - alpha;
        }

        if (alpha <= 0)
        {
            flag = true;
        }
    }

    public void OnClick()
    {
        if (flag == true)
        {
            flag = false;
            count++;
            alpha = 1;
        }
    }
}

