/*@uthor : anton vladimir maxim*/

using UnityEngine;
using System.Collections;

public class on_sprites : MonoBehaviour {

	public bool is_roast;
	public bool is_dog;
	public bool is_black_pan;
	public bool is_bowl;
	public bool is_faucet;

	static int flag_for_question = 0;

	public string[] objects_str_arr = { "alert-question-1-dog", "alert-question-2-black-pan", "alert-question-3-bowl" };

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator OnMouseUp()
	{
		if(is_roast)
		{
			GameObject.Find("alert-failed").transform.localScale = new Vector3(1, 1, 1);
			flag_for_question++;
			yield return new WaitForSeconds (2.0f);
			if(flag_for_question >= 3)
			{
				Application.LoadLevel(0);
				yield return true;
			}
			else
			{
				GameObject.Find("alert-failed").transform.localScale = new Vector3(0, 0, 0);
				GameObject.Find(objects_str_arr[flag_for_question-1]).transform.localScale = new Vector3(0, 0, 0);
				GameObject.Find(objects_str_arr[flag_for_question]).transform.localScale = new Vector3(1, 1, 1);
			}
		}
		if (is_dog)
		{
			if (flag_for_question == 0)
			{
				GameObject.Find("alert-success").transform.localScale = new Vector3(1, 1, 1);
				game_data.is_passed_tutorial = true;
				yield return new WaitForSeconds (2.0f);
				Application.LoadLevel(2);
			}
			else
			{
				GameObject.Find("alert-failed").transform.localScale = new Vector3(1, 1, 1);
				flag_for_question++;
				yield return new WaitForSeconds (2.0f);
				if(flag_for_question >= 3)
				{
					Application.LoadLevel(0);
					yield return true;
				}
				else
				{
					GameObject.Find("alert-failed").transform.localScale = new Vector3(0, 0, 0);
					GameObject.Find(objects_str_arr[flag_for_question-1]).transform.localScale = new Vector3(0, 0, 0);
					GameObject.Find(objects_str_arr[flag_for_question]).transform.localScale = new Vector3(1, 1, 1);
				}
			}
		}
		if (is_black_pan)
		{
			if (flag_for_question == 1)
			{
				GameObject.Find("alert-success").transform.localScale = new Vector3(1, 1, 1);
				game_data.is_passed_tutorial = true;
				yield return new WaitForSeconds (2.0f);
				Application.LoadLevel(2);
			}
			else
			{
				GameObject.Find("alert-failed").transform.localScale = new Vector3(1, 1, 1);
				flag_for_question++;
				yield return new WaitForSeconds (2.0f);
				if(flag_for_question >= 3)
				{
					Application.LoadLevel(0);
					yield return true;
				}
				else
				{
					GameObject.Find("alert-failed").transform.localScale = new Vector3(0, 0, 0);
					GameObject.Find(objects_str_arr[flag_for_question-1]).transform.localScale = new Vector3(0, 0, 0);
					GameObject.Find(objects_str_arr[flag_for_question]).transform.localScale = new Vector3(1, 1, 1);
				}
			}
		}
		if (is_bowl)
		{
			if (flag_for_question == 2)
			{
				GameObject.Find("alert-success").transform.localScale = new Vector3(1, 1, 1);
				game_data.is_passed_tutorial = true;
				yield return new WaitForSeconds (2.0f);
				Application.LoadLevel(2);
			}
			else
			{
				GameObject.Find("alert-failed").transform.localScale = new Vector3(1, 1, 1);
				flag_for_question++;
				yield return new WaitForSeconds (2.0f);
				if(flag_for_question >= 3)
					Application.LoadLevel(0);
					else
				{
					GameObject.Find("alert-failed").transform.localScale = new Vector3(0, 0, 0);
					GameObject.Find(objects_str_arr[flag_for_question-1]).transform.localScale = new Vector3(0, 0, 0);
					GameObject.Find(objects_str_arr[flag_for_question]).transform.localScale = new Vector3(1, 1, 1);
				}
			}
		}
		if (is_faucet)
		{
			GameObject.Find("alert-failed").transform.localScale = new Vector3(1, 1, 1);
			flag_for_question++;
			yield return new WaitForSeconds (2.0f);
			if(flag_for_question >= 3)
				Application.LoadLevel(0);
			else
			{
				GameObject.Find("alert-failed").transform.localScale = new Vector3(0, 0, 0);
				GameObject.Find(objects_str_arr[flag_for_question-1]).transform.localScale = new Vector3(0, 0, 0);
				GameObject.Find(objects_str_arr[flag_for_question]).transform.localScale = new Vector3(1, 1, 1);
			}
		}
	}
}
