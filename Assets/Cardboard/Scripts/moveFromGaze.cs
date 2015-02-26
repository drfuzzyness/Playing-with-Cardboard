using UnityEngine;
using System.Collections;

public class moveFromGaze : MonoBehaviour {

	public float forceAmt;
	public CardboardHead cbhead;

	// Update is called once per frame
	void FixedUpdate () {
		rigidbody.AddForce( cbhead.Gaze.direction.normalized * forceAmt );
//		Debug.Log( cbhead.Gaze.direction.normalized );
	}
}
