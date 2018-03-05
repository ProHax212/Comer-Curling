using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurlingController : MonoBehaviour {

	public FollowCamera followingCamera;
	public CurlingStone curlingStone_p;

	public Transform stoneSpawnPoint;
	public float initialPushingForce = 100f;

	// Use this for initialization
	void Start () {
		// Check for camera
		Debug.Assert(followingCamera);

		// Check for spawn point
		Debug.Assert(stoneSpawnPoint);
	}
	
	// Update is called once per frame
	void Update () {
		checkInput ();
	}

	private void checkInput(){
		spawnStone ();
	}

	private void spawnStone(){
		// Press space to spawn a stone
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Create the stone
			CurlingStone stone = Instantiate (curlingStone_p, stoneSpawnPoint.position, Quaternion.identity);
			stone.GetComponent<Rigidbody> ().AddForce (Vector3.forward * initialPushingForce);	// Add initial force
			followingCamera.changeTarget (stone.transform);	// Make camera follow the stone
		}
	}

}
