using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SEManager : MonoBehaviour {

	[SerializeField]
	private AudioClip[] GUISE = new AudioClip[2];
	[SerializeField]
	private AudioClip[] GameSE = new AudioClip[5];//1ゲーム→ポーズSE,2オーバーSE,3ポーズ→ゲームSE,4リザルトSE,5newレコードリザルトSE

	private AudioSource audiosource;
	int GameSEID;
	int GUILength = 2;

	// Use this for initialization
	void Start () {
		audiosource = this.gameObject.GetComponent<AudioSource>();
		audiosource.Play ();
	}

	// Update is called once per frame
	void Update () {

	}
	public void PlayGameSE(){
		Debug.Log ("Sanic");
		if (GameSEID < 0 || GameSEID >= GameSE.Length) {
			Debug.Log ("Gameのif");
			return;
		}
		audiosource.clip = GameSE [GameSEID];
		audiosource.Play ();
		Debug.Log ("Gameの音");
	}


	public void PlayGUISE(int ID){
		if (GUISE.Length == 0) {
			Debug.Log ("空です");
		}
		Debug.Log (ID);
		Debug.Log (GUISE.Length);
		if (ID < 0 || ID >= GUISE.Length) {
			Debug.Log ("GUIのif");
			return;
		}

		audiosource.clip = GUISE [ID];
		Debug.Log ("aaa");
		audiosource.Play ();
		Debug.Log ("GUIの音");
	}
}