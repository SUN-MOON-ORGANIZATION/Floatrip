using UnityEngine;
using System.Collections;

public class BGMManager : MonoBehaviour {

	public AudioSource introBGM;
	public AudioSource loopBGM;
	AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		introBGM = GameObject.Find("intro").GetComponent<AudioSource> ();
		loopBGM = GameObject.Find ("loop").GetComponent<AudioSource> ();

		introBGM.Play();//始まった時イントロのBGMを流す
		Invoke ("DelayBGM", 30.1f);//30秒のイントロ流れた後ループBGMを流す
	}
	void DelayBGM(){
		loopBGM.Play ();
	}
		
}
