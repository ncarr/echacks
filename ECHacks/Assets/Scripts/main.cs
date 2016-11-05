using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	public static GameObject garbage;
	private static string objectToLoad;
	private static string[] prefabs;

	public static void findNewObject() {
		objectToLoad = prefabs [Random.Range (0, prefabs.Length)];
		garbage = Instantiate(Resources.Load(objectToLoad, typeof(GameObject))) as GameObject;
	}

	public static void Init() {
		//Hardcoded list of instances
		prefabs = new string[] { "Rtinfoil"}; //, "Cbanana" };
		main.findNewObject ();
		moveDampScript.targetPosition = new Vector3 (0, 1, 2);
		garbage.transform.position = new Vector3 (0, 1, 2);
	}
}
