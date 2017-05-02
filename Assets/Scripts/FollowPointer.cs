using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPointer : MonoBehaviour {

	public GameObject pointerObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		pointerObject.GetComponent<Transform> ().position = Input.mousePosition;
	}
}
