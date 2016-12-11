using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;

	private GameObject ScoreText;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");

		this.ScoreText = GameObject.Find("Score");
	}

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
	}

	void OnCollisionEnter(Collision collision) {

		// スコアを加算する。
		if (collision.gameObject.tag == "SmallStarTag") { 
			ScoreText.SendMessage ("AddScore", 10);
		} else if (collision.gameObject.tag == "LargeStarTag") {
			ScoreText.SendMessage ("AddScore", 20);
		} else if (collision.gameObject.tag == "SmallCloudTag") {
			ScoreText.SendMessage ("AddScore", 10);
		} else if (collision.gameObject.tag == "LargeCloudTag") {
			ScoreText.SendMessage ("AddScore", 20);
		}
	}
}