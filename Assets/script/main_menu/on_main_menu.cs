/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_main_menu : MonoBehaviour {

	public bool is_training;
	public bool is_game;

	public TextMesh text_tutorial_first;
	private bool is_showed_text;
	private float show_time;
	// Use this for initialization
	void Start () {
		text_tutorial_first.text = "";
		is_showed_text = false;
		show_time = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (is_showed_text)
		{
			show_time -= Time.deltaTime;
			if (show_time < 0)
			{
				text_tutorial_first.text = "";
				is_showed_text = false;
				show_time = 3.0f;
			}
		}
	}

	void OnMouseUp()
	{
		if(is_training)
		{
			Application.LoadLevel(1);
		}
		if(is_game)
		{
			if(game_data.is_passed_tutorial)
				Application.LoadLevel(2);
			else
			{
				text_tutorial_first.text = "!tutorial first";
				is_showed_text = true;
			}
		}
	}
}
