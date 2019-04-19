/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_sprites_level1 : MonoBehaviour {

	private int[] which_sprite = {4, 2, 1};
	private string[] sprite_tags = {"back", "wheel", "cage", "round-mark", "small-house", "big-house"};
	private bool is_over;

	// Use this for initialization
	void Start () {
		is_over = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp()
	{
		if(gameObject.tag == sprite_tags[which_sprite[game_data.question_number]])
		{
			// success
			game_data.score += game_data.score_add_amount;
			game_data.number_of_success += 1;
			game_data.is_need_next = 3; // sucess
		}
		else
			game_data.is_need_next = 2; // failed
		game_data.timer = 0;
	}

	void OnMouseOver()
	{
		if(!is_over)
		{
			gameObject.transform.localScale *= 1.1f;
			is_over = true;
		}
	}

	void OnMouseExit()
	{
		if(is_over)
		{
			gameObject.transform.localScale /= 1.1f;
			is_over = false; 
		}	
	}
}
