using UnityEngine;
using System.Collections;

public class Girl : MonoBehaviour {
    private GameObject balloon = null;
    [SerializeField]
    private float girlPos;
    [SerializeField]
    private float girlSpeed;
    Vector3 balloonPos;
	// Use this for initialization
	void Start () {
        if (balloon == null) balloon = GameObject.Find("Balloon");
        balloonPos = balloon.transform.position;
        balloonPos.y = balloonPos.y - girlPos;
        this.transform.position = balloonPos;
    }
	
	// Update is called once per frame
	void Update () {
        balloonPos = balloon.transform.position;
        balloonPos.y = balloonPos.y - girlPos;
        this.transform.position = Vector3.Lerp(this.transform.position, balloonPos,girlSpeed * Time.deltaTime);
	}
}
