/*@uthor : anton vladimirovich maxim*/

using UnityEngine;
using System.Collections;

public class on_menu_click : MonoBehaviour {

	public bool is_heart;
	public bool is_star;
	public bool is_clock;
	public bool is_exit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver()
	{
		if(is_heart)
		{
			GameObject.Find("heart").transform.localScale = new Vector3(0.14f, 0.14f, 1.0f);
		}
		if(is_star)
		{
			GameObject.Find("star").transform.localScale = new Vector3(0.22f, 0.22f, 1.0f);
		}
		if(is_clock)
		{
			GameObject.Find("clock").transform.localScale = new Vector3(0.84f, 0.84f, 1.0f);
		}
		if(is_exit)
		{
			GameObject.Find("arrow").transform.localScale = new Vector3(1.48f, 1.08f, 1.0f);
		}
	}

	void OnMouseExit()
	{
		if(is_heart)
		{
			GameObject.Find("heart").transform.localScale = new Vector3(0.12f, 0.12f, 1.0f);
		}
		if(is_star)
		{
			GameObject.Find("star").transform.localScale = new Vector3(0.2f, 0.2f, 1.0f);
		}
		if(is_clock)
		{
			GameObject.Find("clock").transform.localScale = new Vector3(0.8f, 0.8f, 1.0f);
		}
		if(is_exit)
		{
			GameObject.Find("arrow").transform.localScale = new Vector3(1.4f, 1.0f, 1.0f);
		}
	}

	void OnMouseUp()
	{
		if(is_exit)
		{
			Application.LoadLevel(2);
		}
	}
}
