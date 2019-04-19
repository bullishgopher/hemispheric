using UnityEngine;
using System.Collections;

public class score_show : MonoBehaviour {
	public TextMesh text_for_score;
	// Use this for initialization
	void Start () {
		text_for_score.text = game_data.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		text_for_score.text = game_data.score.ToString();
	}
}
