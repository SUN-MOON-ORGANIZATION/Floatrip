using UnityEngine;
using System.Collections;

public class Crown : MonoBehaviour {
    public float breaktime;
    public float yspeed;
	// Use this for initialization
	void Start ()
    {
        Destroy(this.gameObject, breaktime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - yspeed/100, transform.position.z);
	}
}
