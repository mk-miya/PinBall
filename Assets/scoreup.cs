using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class scoreup : MonoBehaviour {

	public int  score = 0;

	// Use this for initialization
	void Start () {
	}

	void AddScore(int score) {
		this.score += score;
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = "Score:" + this.score;
	}
}
