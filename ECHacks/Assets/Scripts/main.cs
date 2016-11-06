using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	public static GameObject garbage;
    public static bool destroy = false;
	private static string objectToLoad;
	private static string[] prefabs;
	private static TextMesh gooey = Instantiate(Resources.Load("nameCanvas", typeof(TextMesh))) as TextMesh;

	public static void findNewObject() {
		objectToLoad = prefabs [Random.Range (0, prefabs.Length)];
		garbage = Instantiate(Resources.Load(objectToLoad, typeof(GameObject))) as GameObject;
		gooey.text = objectToLoad;
	}

	public static void Init() {
		//Hardcoded list of instances
		prefabs = new string[] {"Tinfoil", "Banana Peel" };
		main.findNewObject();
		moveDampScript.targetPosition = new Vector3 (0, 1, 2);
		garbage.transform.position = new Vector3 (0, 1, 2);
	}
}
