using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleScript : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "PlayerBall") {
			Debug.Log ("loose !");
			ScoreCount.score = 0;
			SceneManager.LoadScene("playTime");
		}
		if (col.gameObject.tag == "Ball") {
			++ScoreCount.score;
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "8Ball") {
			if (ScoreCount.score == 14) {
				Debug.Log ("Win");
				ScoreCount.score = 0;
				SceneManager.LoadScene("playTime");
			} else {
				Debug.Log ("loose !");
				ScoreCount.score = 0;
				SceneManager.LoadScene("playTime");
			}
		}
	}
}
