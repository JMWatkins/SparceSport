using UnityEngine;
using System.Collections;

public class Seeker : MonoBehaviour {
	private float acceleration = 3f;
	private float predictionDetection = 1f;
	private float maneuverability = 0.5f;
	public GameObject prefab;
	//private Object refr;
	// Use this for initialization
	void Start () {
		//refr = Instantiate(prefab, new Vector3(0f,0f, 0f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update ()
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
		//find target (closest to position that will be held in X time
		GameObject target = TargetHelper.findClosestPlayer (rb, rb.velocity.magnitude * predictionDetection);
		//get direction to target
		Vector3 dirToTar = rb.transform.position - target.transform.position;
		/*	//display marker
			Destroy(refr);
			refr = Instantiate(prefab, -(rb.position+dirToTar.normalized), Quaternion.identity);
		*/
		//set course and compensate for current velocity (adjust/tweek for focusing on target or balancing out momentum)
		rb.AddForce((-(dirToTar*maneuverability + rb.velocity).normalized)*acceleration);
	}
}
