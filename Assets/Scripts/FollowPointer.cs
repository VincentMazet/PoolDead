using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPointer : MonoBehaviour {

	public GameObject pointerObject;

	void FixedUpdate () {
		pointerObject.GetComponent<Transform> ().position = Input.mousePosition;
	}
}
