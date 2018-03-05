using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurlingStone : MonoBehaviour {

	public float arrowRotateSpeed = 5.0f;
	public Transform arrow;

	private float arrowAngle = 0.0f;	// This is used each frame to update the arrow position

	// Use this for initialization
	void Start () {
		Debug.Assert (arrow);
	}
	
	// Update is called once per frame
	void Update () {
		checkInput ();
	}

	// Update the arrow change
	void LateUpdate(){
		arrow.RotateAround (transform.position, transform.up, arrowAngle * arrowRotateSpeed * Time.deltaTime);
	}

	private void checkInput(){
		changeArrow ();
	}

	// Use arrow keys to move the arrow around the curling stone
	// The arrow is used for physics direction
	private void changeArrow(){
		// Rotate counter-clockwise
		if (Input.GetKey (KeyCode.LeftArrow)) {
			arrowAngle = -1.0f;
		}
		// Rotate clockwise
		else if (Input.GetKey (KeyCode.RightArrow)) {
			arrowAngle = 1.0f;
		} else {
			arrowAngle = 0.0f;	// No input, don't change
		}
	}
}
