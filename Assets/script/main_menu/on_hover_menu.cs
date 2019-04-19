/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_hover_menu : MonoBehaviour {

	public bool is_training;
	public bool is_game;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver()
	{
		if(is_training)
		{
			GameObject.Find("menu_training").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
		}
		if(is_game)
		{
			GameObject.Find("menu_game").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
		}
	}

	void OnMouseExit()
	{
		if(is_training)
		{
			GameObject.Find("menu_training").transform.localScale = new Vector3(1, 1, 1);
		}
		if(is_game)
		{
			GameObject.Find("menu_game").transform.localScale = new Vector3(1, 1, 1);
		}	
	}
}
