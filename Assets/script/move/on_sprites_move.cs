/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_sprites_move : MonoBehaviour {

	private int[] which_sprite = {4, 2, 1};
	private string[] sprite_tags = {"back", "wheel", "cage", "round-mark", "small-house", "big-house"};
	private bool is_over;

	private bool is_moving;
	private Vector2[] points = {
		new Vector2(-7.81f, 2.67f), 
		new Vector2(8.87f, 2.33f), 
		new Vector2(4.81f, 2.04f),
		new Vector2(9.17f, -1.46f),
		new Vector2(-8.98f, -2.42f),
		new Vector2(-1.74f, -1.02f),
		new Vector2(7.57f, -3.94f),
		new Vector2(8.85f, 3.80f),
		new Vector2(0f, 0f),
		new Vector2(-0.67f, 4.85f),
		new Vector2(9.85f, -3.5f),
		new Vector2(0.5f, -0.61f),
		new Vector2(3.44f, 1.26f),
		new Vector2(-0.72f, -3.31f),
		new Vector2(5.74f, -0.35f),
		new Vector2(2.11f, -0.56f),
		new Vector2(-3f, -3.46f),
		new Vector2(8.65f, 2.83f),
		new Vector2(-8.30f, -2.85f),
		new Vector2(-9.8f, 2.55f),
		new Vector2(8.78f, 0.83f),
		new Vector2(-7.59f, 0.31f),
		new Vector2(-2.0f, 4.12f),
		new Vector2(8.2f, 2f),
		new Vector2(-2.9f, 3.72f),
		new Vector2(7.18f, -3.4f),
		new Vector2(0f, 0f)
};
	private const float radius = 4.0f;

	// Use this for initialization
	void Start () {
		is_over = false;
		is_moving = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(is_moving)
		{
			Vector3 mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			GameObject.FindWithTag(sprite_tags[which_sprite[game_data.question_number]]).transform.position = new Vector3(mousePosition.x, mousePosition.y, -1.0f);
		}
	}

	void OnMouseDown()
	{
		Vector3 mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		if(gameObject.tag == sprite_tags[which_sprite[game_data.question_number]])
		{
			is_moving = true;
		}
	}

	void OnMouseUp()
	{
			Vector3 mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			/*int temp_id=0;
			if (game_data.current_level==4)
			{
				temp_id = 9*2+15;
			}
			else if(game_data.current_level < 4)
			{
				temp_id = 9*(game_data.current_level - 1);
			}*/
			if(is_moving && points[(game_data.current_level-3)*15 + game_data.pic_number * 3 + game_data.question_number].x - radius < mousePosition.x && points[(game_data.current_level-3)*15 + game_data.pic_number * 3 + game_data.question_number].x + radius >mousePosition.x && points[(game_data.current_level-3)*15 + game_data.pic_number * 3 + game_data.question_number].y - radius <mousePosition.y && points[(game_data.current_level-3)*15 + game_data.pic_number * 3 + game_data.question_number].y + radius >mousePosition.y)
			{
				//success
				game_data.score += game_data.score_add_amount;
				game_data.number_of_success += 1;
				game_data.is_need_next = 3; // sucess
			}
			else{
				game_data.is_need_next = 2; // failed
			}
			is_moving = false;
			if(gameObject.tag == sprite_tags[which_sprite[game_data.question_number]])
			{
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
