/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_level_menu : MonoBehaviour {

	public bool[] which_level;
	private int[] scene_number_levels = {1, 3, 6, 9, 14, 19, 24, 29};

	public bool is_exit_menu;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp()
	{
		for (int i = 0; i < 7; i++)
		{
			if(which_level[i])
			{
				game_data.current_level = i + 1;
				game_data.pic_number = 0;
				game_data.question_number = 0;
				Application.LoadLevel(scene_number_levels[game_data.current_level]);
			}
		}
		if (is_exit_menu)
		{
			Application.LoadLevel(0);
		}
	}
}
