using UnityEngine;
using System.Collections;

public class crawler : MonoBehaviour {
	private bool moving = false;

	public Animator animator;

	private float timer = .5f;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (timer > 0) {
			timer -= 1 * Time.fixedDeltaTime;
		} else if (timer <= 0) {
			move ();
		}
		if (moving) {
			transform.Translate (Vector3.left * 3 * Time.fixedDeltaTime);
		}
	}

	void move(){
		moving = true;

		animator.SetBool ("crawl", true);
	}
}
