using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1;
	private Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal") * 0.1f * speed;
		float vertical = Input.GetAxis ("Vertical") * 0.1f * speed;

		if (vertical < 0.0)
			animator.Play ("Walk Down");
		Debug.Log (vertical);

		transform.Translate (horizontal, vertical, 0);

	}
}
