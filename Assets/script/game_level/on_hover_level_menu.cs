/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_hover_level_menu : MonoBehaviour {

	public bool[] which_level;
	private string[] object_name = {"lvl-1", "lvl-2", "lvl-3", "lvl-4", "lvl-5", "lvl-6", "lvl-7"};

	public bool is_exit_menu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver()
	{
		for (int i = 0; i < 7; i++)
		{
			if(which_level[i])
			{
				GameObject.Find(object_name[i]).transform.localScale = new Vector3(0.12f, 0.12f, 1.0f);
			}
		}
		if (is_exit_menu)
		{
			GameObject.Find("arrow_back").transform.localScale = new Vector3(1.2f, 1.2f, 1.0f);
		}
	}

	void OnMouseExit()
	{
		for (int i = 0; i < 7; i++)
		{
			if(which_level[i])
			{
				GameObject.Find(object_name[i]).transform.localScale = new Vector3(0.1f, 0.1f, 1.0f);
			}
		}
		if (is_exit_menu)
		{
			GameObject.Find("arrow_back").transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		}
	}
}
