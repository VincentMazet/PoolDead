using UnityEngine;
using System.Collections;

public class PositionTest : MonoBehaviour {

	public GameObject centerHit;
	public GameObject ball;
	public GameObject pointer;
	public float relativeX;
	public float relativeY;
	public float relativeZ;

	Transform centerTransform;
	Transform pointerTransform;

	public float torque = 10;

	void Start(){
		centerTransform = centerHit.GetComponent<Transform> ();
		pointerTransform = pointer.GetComponent<Transform> ();
	}

	void FixedUpdate () {
		testRoL ();
	}

	public void testRoL(){
		//verification position curseur par rapport à la balle blanche
		Vector3 relativePoint = centerTransform.InverseTransformDirection (pointerTransform.position);

		relativeX = relativePoint.x - Screen.width/2; //calculs en fonction de la taille de l'ecran
			relativeY = relativePoint.y - Screen.height/2;

		Vector3 direction = new Vector3();

		//orienter le curseur en fonction du centre pour choisir l'angle de "frappe" sur la boule blanche
		//plus le curseur est éloigné du centre plus le tir est fort
		direction.x = -relativeX;
		direction.z = -relativeY;

		if(Input.GetButton("Fire1")){
			//Ajout d'un "couple" pour pouvoir gerer manuelement la puissance de "frappe"
			ball.GetComponent<Rigidbody>().AddForce (direction * torque, ForceMode.Impulse);
		}
	}
}
