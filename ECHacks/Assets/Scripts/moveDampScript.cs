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
        if (main.destroy && velocity != Vector3.zero) {
            Destroy(main.garbage);
            main.findNewObject();
            targetPosition = new Vector3(0, 1, 2);
            main.garbage.transform.position = new Vector3(0, 1, 2);
        }
	}
}
