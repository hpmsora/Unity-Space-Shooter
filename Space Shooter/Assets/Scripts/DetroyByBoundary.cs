using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyByBoundary : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		Destroy (other.gameObject);
	}
}
