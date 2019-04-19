/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_question : MonoBehaviour {

	public TextMesh TEXT;

	//public TextMesh text_for_score;

	//private string[] questions = {"!click on the small house", "!click on the bird cage", "!move wheel to small house"};
private string[] questions = 
{"!click on the small house",
"!click on the bird cage",
"!click on the wheel",
"!click on the small house",
"!click on the biggest tree",
"!click on the dish",
"!click on the well",
"!click on the road",
"!click on the biggest house",
"!click on the monkey",
"!click on the white rabbit",
"!click on the pink sheep",
"!click on the red tree",
"!click on the green wood",
"!click on the red stone",
"!click on the monkey",
"!click on the white rabbit",
"!click on the pink sheep",
"!move monkey to left house",
"!move white rabbit to right house",
"!move pink sheep near the cat",
"!move red tractor to right house",
"!move biggest cloud to blue car",
"!move sun to the biggest house",
"!move bucket near kettle",
"!move sun near the star",
"!move house to center",
"!move big chimney to small chimney",
"!move kettle near boot",
"!move tree near shovel",
"!move monkey to the house",
"!move white rabbit next to blue rabbit",
"!move pink sheep near the cat",
"!move yellow baby to orange baby",
"!move red baby to pink baby",
"!move green baby to blue baby",
"!move girl with orange shirt to 2",
"!move girl with red shirt to 1",
"!move girl with yellow shirt to 3",
"!move crying baby to $",
"!move bathing baby to B",
"!move baby with one red ribbon to 1",
"!move hunter to 2",
"!move boy with a ball to 1",
"!move girl with roller skate to center",
"!move the bag to 1",
"!move the girl with a bag to school",
"!move the girl with gray cap to 2"
};

	private int len_of_question;
	private int index_que_string;
	
	private string[] evaluations = {"!success, the next", "!success, you finished", "!wrong, the next", "!wrong, you finished"};
	private int which_evaluation = -1;
	private int len_of_evaluation;

	private float delta_time;
	private string current;

	private bool to_next_true; // to next step

	private bool need_audio = true;

	public AudioClip[] q_audio;

	private int[] scene_number_levels = {1, 3, 6, 9, 14, 19, 24, 29};
	// Use this for initialization
	void Start () {
		current = "";
		delta_time = 0.1f;
		int temp_id=0;
		if (game_data.current_level==4)
		{
			temp_id = 9*2+15;
		}
		else if(game_data.current_level < 4)
		{
			temp_id = 9*(game_data.current_level - 1);
		}
		len_of_question = questions[temp_id + game_data.pic_number * 3 + game_data.question_number].Length;
		index_que_string = 0;
		to_next_true = false;
		game_data.timer = 0;
		which_evaluation = -1;
		//text_for_score.text = game_data.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//////////////////////////////////////Evaluation//////////////
		//text_for_score.text = game_data.score.ToString();
		if (which_evaluation != -1)
		{
			delta_time -= Time.deltaTime;
			len_of_evaluation = evaluations[which_evaluation].Length;

			if (delta_time < 0 && index_que_string<len_of_evaluation)
			{
				current += evaluations[which_evaluation][index_que_string]; //index_que_string = index_eva_string
				index_que_string++;
				TEXT.text = current;
				delta_time = 0.1f;
			}
			if(index_que_string>=len_of_evaluation) //if finished displaying letters
			{
				if(to_next_true)
				{
					game_data.question_number = 0;
					if(game_data.pic_number < 2)
						game_data.pic_number ++;
					else
					{
						game_data.pic_number = 0;
						if(game_data.current_level<6)
							game_data.current_level++;
						if (game_data.number_of_success >= game_data.max_pic_number[game_data.current_level-2] * 3 * 0.75)// success more than 75%
						{
							Debug.Log("success - next level");
							game_data.number_of_success = 0;
							Application.LoadLevel(scene_number_levels[game_data.current_level]);// go to next level
							to_next_true = false;
							return;
						}
						else
						{
							Debug.Log("fail - previous level");
							game_data.number_of_success = 0;
							Application.LoadLevel(scene_number_levels[game_data.current_level-2]);// go to previous level
							to_next_true = false;
							return;
						}
					}
					Application.LoadLevel(scene_number_levels[game_data.current_level] + game_data.pic_number);
					to_next_true = false;
				}

				which_evaluation = -1;
				index_que_string = 0;
				current = "";
			}
		}

		if (game_data.is_need_next==0 && which_evaluation == -1)//question
		{
			if(need_audio)
			{
				int temp_id=0;
				if (game_data.current_level==4)
				{
					temp_id = 9*2+15;
				}
				else if(game_data.current_level < 4)
				{
					temp_id = 9*(game_data.current_level - 1);
				}
				AudioSource.PlayClipAtPoint(q_audio[temp_id + game_data.pic_number * 3 + game_data.question_number], transform.position);
				need_audio = false;
			}
			delta_time -= Time.deltaTime;
			if (delta_time < 0 && index_que_string<len_of_question)
			{
				int temp_id=0;
				if (game_data.current_level==4)
				{
					temp_id = 9*2+15;
				}
				else if(game_data.current_level < 4)
				{
					temp_id = 9*(game_data.current_level - 1);
				}
				current += questions[temp_id + game_data.pic_number * 3 + game_data.question_number][index_que_string];
				index_que_string++;
				TEXT.text = current;
				delta_time = 0.1f;
			}
		}
		else if(game_data.is_need_next == 1)
		{
			which_evaluation = 2;

			need_audio = true;
			if(game_data.question_number<2)
				game_data.question_number++;
			else
				to_next_true = true; // go to next step
			current = "";
			int temp_id=0;
			if (game_data.current_level==4)
			{
				temp_id = 9*2+15;
			}
			else if(game_data.current_level < 4)
			{
				temp_id = 9*(game_data.current_level - 1);
			}
			len_of_question = questions[temp_id + game_data.pic_number * 3 + game_data.question_number].Length;
			index_que_string = 0;
			
			game_data.is_need_next = 0;
		}
		else if(game_data.is_need_next == 2)
		{
			which_evaluation = 2;

			need_audio = true;
			if(game_data.question_number<2)
				game_data.question_number++;
			else
				to_next_true = true; // go to next step
			current = "";

			int temp_id=0;
			if (game_data.current_level==4)
			{
				temp_id = 9*2+15;
			}
			else if(game_data.current_level < 4)
			{
				temp_id = 9*(game_data.current_level - 1);
			}
			len_of_question = questions[temp_id + game_data.pic_number * 3 + game_data.question_number].Length;
			index_que_string = 0;
			
			game_data.is_need_next = 0;
		}
		else if(game_data.is_need_next == 3)
		{
			which_evaluation = 0;

			need_audio = true;
			if(game_data.question_number<2)
				game_data.question_number++;
			else
				to_next_true = true; // go to next step
			current = "";
			int temp_id=0;
			if (game_data.current_level==4)
			{
				temp_id = 9*2+15;
			}
			else if(game_data.current_level < 4)
			{
				temp_id = 9*(game_data.current_level - 1);
			}
			len_of_question = questions[temp_id + game_data.pic_number * 3 + game_data.question_number].Length;
			index_que_string = 0;
			
			game_data.is_need_next = 0;
		}
	}
}
