using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
    //0～9
    [SerializeField]
    private Sprite[] sprites;

    private Image image;

	// Use this for initialization
	void Start () {
        this.image = GetComponent<Image>();
	}
	
	public void OnScoreBoard (int number)
    {
        this.image.sprite = this.sprites[number];
	
	}
}
