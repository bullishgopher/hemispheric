using UnityEngine;
using System.Collections;

public class play_audio : MonoBehaviour {
	public AudioClip back_music;
	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint (back_music, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
