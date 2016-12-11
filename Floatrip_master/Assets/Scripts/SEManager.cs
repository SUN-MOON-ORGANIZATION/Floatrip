using UnityEngine;
using System.Collections;

public class SEManager : MonoBehaviour {

	public AudioClip[]GameSE;//1ゲーム→ポーズSE,2オーバーSE,3ポーズ→ゲームSE,4リザルトSE,5newレコードリザルトSE
	public AudioClip[]GUISE;//1タイトルSEタップ音
	private AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = this.gameObject.GetComponent<AudioSource>();
		audiosource.Play ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void playGameSE(int SEID){
		if (SEID < 0 || SEID >= GameSE.Length)
			return;
		audiosource.clip = GameSE [SEID];
		audiosource.Play ();
	}

	public void PlayGUISE(int SEID){
		if (SEID < 0 || SEID >= GUISE.Length)
			return;
		audiosource.clip = GUISE [SEID];
		audiosource.Play ();
	}
}
