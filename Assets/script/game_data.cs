/*@uthor : anton vladimir maxim*/

using UnityEngine;
using System.Collections;

public class game_data : MonoBehaviour {
	//------------------tutorial-------------------//
	static public bool is_passed_tutorial = false;

	//------------------level-------------------//
	static public int current_level = 0;//1~7

	static public int timer = 0;//0~15
	static public int max_time = 15;

	static public int pic_number = 0;
	static public int[] max_pic_number = {3, 3, 5, 5, 5, 5, 6};

	static public int question_number = 0;//0, 1, 2
	static public int max_question_number = 3;

	static public int score = 30;
	static public int score_add_amount = 10;

	static public int number_of_success = 0; // number of success in current level - to check success more than 75% - 0~9

	static public int is_need_next = 0; //0:don't need  1:need, time over, failed  2:need, failed  3:need, success ----- to next level
}
