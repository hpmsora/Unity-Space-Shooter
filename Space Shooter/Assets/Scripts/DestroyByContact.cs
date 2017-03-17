using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameConroller;

	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameConroller = gameControllerObject.GetComponent<GameController> ();
		}
		if (gameConroller == null) {
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary") {
			return;
		}
		Instantiate (explosion, transform.position, transform.rotation);
		if (other.tag == "Player") {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			gameConroller.GameOver ();
		}
		gameConroller.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
