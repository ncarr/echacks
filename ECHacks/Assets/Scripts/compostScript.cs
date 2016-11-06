using UnityEngine;
using System.Collections;

public class compostScript : MonoBehaviour, IGvrGazeResponder {

	public GameObject bin;
	private main mainScript;
	private GameObject trash;

	// Update is called once per frame
	void Update () {
		trash = main.garbage;
	}

	#region IGvrGazeResponder implementation

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).
	public void OnGazeEnter() {
		Debug.Log ("Setting target to " + bin.transform.position + "(" + bin.name + ")");
		moveDampScript.targetPosition = bin.transform.position;

	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {

	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {

	}

	#endregion
}
