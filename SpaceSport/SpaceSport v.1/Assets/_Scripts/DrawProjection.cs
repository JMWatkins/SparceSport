using UnityEngine;
using System.Collections;

public class DrawProjection : MonoBehaviour {

	public Object prefab;
	private Object refr;
	// Use this for initialization
	void Start () {
		refr = Instantiate (prefab, TargetHelper.getPositionIn (GetComponent<Rigidbody> (), 10), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (refr);
		refr = Instantiate (prefab, TargetHelper.getPositionIn (GetComponent<Rigidbody> (), 10), Quaternion.identity);
	}
}
