using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class massChanger : MonoBehaviour {
	[SerializeField]
	private float mass;
	private Rigidbody _rigidbody;



	public Text massText;

	// Use this for initialization
	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();

		_rigidbody.mass = mass;
		mass = 1;
	}
		
	

	void Update () {
		
		_rigidbody.mass = mass;

		if (mass < 1) {
			mass = 1;
		} else if (mass > 20) {
			mass = 20;
		}

		changeMass ();
		text ();
	}

	void changeMass(){
		if (Input.GetKey ("right")&& mass < 20) {
			mass += 10 * Time.fixedDeltaTime;
		}
		if (Input.GetKey ("left") && mass > 1) {
			mass -= 10 * Time.fixedDeltaTime;
		}

	
	}

	void text(){

		massText.text = "Mass: " + mass ;
	}
}
