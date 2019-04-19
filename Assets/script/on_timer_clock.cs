/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_timer_clock : MonoBehaviour {

	public TextMesh TEXT;
	private float second = 1.0f;

	// Use this for initialization
	void Start () {
		TEXT.text = "0:0";
	}
	
	// Update is called once per frame
	void Update () {
		second -= Time.deltaTime;
		if (second < 0)
		{
			game_data.timer += 1;
			if (game_data.timer <15)
				TEXT.text = "0:" + game_data.timer.ToString();
			else
			{
				game_data.timer = 0;
				TEXT.text = "0:" + game_data.timer.ToString();
				game_data.is_need_next = 1; // failed
				game_data.timer = 0;
			}
			second = 1.0f;
		}
	}
}
