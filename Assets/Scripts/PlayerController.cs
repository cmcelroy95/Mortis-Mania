using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1;
	private int direction = 0;
	private Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal") * 0.1f * speed;
		float vertical = Input.GetAxis ("Vertical") * 0.1f * speed;

		if (vertical != 0)
			horizontal = 0;

		if (vertical < 0.0) {
			animator.Play ("Walk Down");
			direction = 0;
		} else if (vertical > 0.0) {
			animator.Play ("Walk Up");
			direction = 2;
		} else if (horizontal < 0.0) {
			animator.Play ("Walk Left");
			direction = 1;
		} else if (horizontal > 0.0) {
			animator.Play ("Walk Right");
			direction = 3;
		} else {
			switch (direction) {
			case 0:
				animator.Play ("Idle Down");
				break;
			case 1:
				animator.Play ("Idle Left");
				break;
			case 2:
				animator.Play ("Idle Up");
				break;
			default:
				animator.Play ("Idle Right");
				break;
			}
		}
		
		Debug.Log (vertical);

		transform.Translate (horizontal, vertical, 0);

	}
}
