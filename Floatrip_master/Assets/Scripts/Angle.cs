using UnityEngine;
using System.Collections;

public class Angle : MonoBehaviour
{
    private GameObject balloon, girl;
    private float rad,dx,dy;
    // Use this for initialization
    void Start()
    {
        balloon = GameObject.FindGameObjectWithTag("Balloon");
        girl = GameObject.FindGameObjectWithTag("Girl");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) GetAngle();
        if (Input.GetMouseButtonUp(0)) this.transform.rotation = Quaternion.Euler(0, 0, 0);
        this.transform.position = new Vector3(balloon.transform.position.x, this.transform.position.y, this.transform.position.z);

    }
    void GetAngle()
    {
        dx = balloon.transform.position.x - girl.transform.position.x;
        dy = balloon.transform.position.y - girl.transform.position.y;
        rad = Mathf.Atan2(dy, dx);
        //rad = Vector3.Angle(balloon.transform.position, girl.transform.position);
        if (girl.transform.position.x > balloon.transform.position.x) rad = -rad;
        this.transform.rotation = Quaternion.Euler(0,0,-rad);
    }
}
