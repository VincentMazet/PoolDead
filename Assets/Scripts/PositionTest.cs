using UnityEngine;
using System.Collections;

public class PositionTest : MonoBehaviour {

	public GameObject ball;
	public GameObject pointer;
	Transform ballTransform;
	Transform pointerTransform;

	public float relativeX;
	public float relativeY;
	public float relativeZ;

	void Start(){
		ballTransform = ball.GetComponent<Transform> ();
		pointerTransform = pointer.GetComponent<Transform> ();
	}

	void FixedUpdate () {
		testRoL ();
	}


	public void testRoL(){
		
		Vector3 relativePoint = ballTransform.InverseTransformVector (pointerTransform.position);


		relativeX = relativePoint.x - Screen.width/2;
		relativeY = relativePoint.y - Screen.height/2;
		relativeZ = relativePoint.z;
		Debug.Log(relativeX + "//" + relativeY);


		Vector3 direction = new Vector3();

		if (relativeX < 0.0) {
			direction.x = 50;
		} else if (relativeX > 0.0) {
			direction.x = -50;
		} else {
			direction.x = 0;
		}

		if (relativeY < 0.0) {
			direction.z = 50;
		} else if (relativeY > 0.0) {
			direction.z = -50;
		} else {
			direction.z = 0;
		}

		if(Input.GetButton("Fire1")){
			ball.GetComponent<Rigidbody>().AddForce (direction * 25, ForceMode.Impulse);
		}
	}
}
