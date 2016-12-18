using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour {

	public AudioSource introBGM;
	public AudioSource loopBGM;
	AudioSource audioSource;
	string sceneName;
	
	// Use this for initialization
	void Start () {
		sceneName = SceneManager.GetActiveScene ().name;
		introBGM = GameObject.Find("IntroBGM").GetComponent<AudioSource> ();
		loopBGM = GameObject.Find ("LoopBGM").GetComponent<AudioSource> ();

		introBGM.Play();//始まった時イントロのBGMを流す
		if(sceneName=="Title"){
			Invoke ("DelayBGM", 30.0f);//30秒のイントロ流れた後ループBGMを流す
		}
		if (sceneName == "Main") {
			Invoke ("DelayBGM", 80.0f);//80秒のイントロが流れた後ループBGMを流す
		}
	}
	void DelayBGM(){
		loopBGM.Play ();
	}
		
}
