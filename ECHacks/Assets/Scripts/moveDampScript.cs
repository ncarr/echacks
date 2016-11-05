using UnityEngine;
using System.Collections;

public class moveDampScript : MonoBehaviour {

	public Transform transform;
	public static Vector3 targetPosition;
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update() {
		if (targetPosition != null) {
			transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 1);
		}
	}
}
