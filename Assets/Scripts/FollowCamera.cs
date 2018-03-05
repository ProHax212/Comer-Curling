using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public Vector3 positionOffset = new Vector3(0, 2f, -5f);
	private Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		followTarget ();
	}

	// Update the position of the camera to follow the target
	private void followTarget(){
		// Only follow if there is a target
		if (target == null || !target.gameObject.activeInHierarchy) {
			return;
		}

		transform.position = target.TransformPoint(target.position + positionOffset);
		transform.LookAt (target);
	}

	// Change the target that the camera follows
	public void changeTarget(Transform newTarget){
		target = newTarget;
	}

}
