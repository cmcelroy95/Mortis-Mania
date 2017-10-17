using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	// Use this for initialization
	public int speed;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis ("Horizontal") * 0.1f * speed;
		var y = Input.GetAxis ("Vertical") * 0.1f * speed;
	 	
		if (Input.GetKey("a")) {
			animation.Play ("Player Left");
		}
		transform.Translate (x, y, 0);
	}
}
