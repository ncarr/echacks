using UnityEngine;
using System.Collections;

public class moveDampScript : MonoBehaviour {

	public Transform transformersRevengeOfTheFallen;
	public static Vector3 targetPosition;
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update() {
		transform.position = Vector3.SmoothDamp(transformersRevengeOfTheFallen.position, targetPosition, ref velocity, 1);
	}
}
