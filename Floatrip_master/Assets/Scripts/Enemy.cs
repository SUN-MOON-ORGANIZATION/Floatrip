using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    [SerializeField]
    private float lateral;
    private Player player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Balloon").GetComponent<Player>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if(this.gameObject.tag == "Bird")
        {
            BirdMove();
        }
	
	}
    void BirdMove()
    {
        this.transform.position += new Vector3(lateral, -player.ScorePlus, 0);
    }
    void OnTriggerEnter2D(Collider2D enemy)
    {
        if(enemy.gameObject.tag == "Balloon")
        {
            Destroy(gameObject);
        }
    }
}
