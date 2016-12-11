using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {
    public Text sco;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once p er frame
	void Update () {
        sco.text = " " + Player.Score;
	}
}
