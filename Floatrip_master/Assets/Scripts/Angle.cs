using UnityEngine;
using System.Collections;

public class Angle : MonoBehaviour
{
    private GameObject balloon, girl;
    private float rad,distance;
    // Use this for initialization
    void Start()
    {
        balloon = GameObject.FindGameObjectWithTag("Balloon");
        girl = GameObject.FindGameObjectWithTag("Girl");
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = (balloon.transform.position.x - girl.transform.position.x) / 4;
        if(Input.GetMouseButton(0)) GetAngle();
        if (Input.GetMouseButtonUp(0)) this.transform.rotation = Quaternion.Euler(0, 0, 0);
        this.transform.position = new Vector3(girl.transform.position.x, this.transform.position.y, this.transform.position.z);

    }
    void GetAngle()
    {
        rad = Vector3.Angle(balloon.transform.position, girl.transform.position);
        if (girl.transform.position.x > balloon.transform.position.x) rad = -rad;
        this.transform.rotation = Quaternion.Euler(0,0,-rad);
    }
}
