using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCount : MonoBehaviour {

	public static int score = 0;
	public Text scoreText;

	void FixedUpdate() {
		scoreText.text ="Score : " +  ScoreCount.score;
	}

}
