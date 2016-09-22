using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public int maxAcc;
	public int maxSpeed;
	// Use this for initialization
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.transform.position = new Vector3(0f,0f,0f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//var test = rb.GetRelativePointVelocity(Vector3(0f,0f,0f));
		float accelerate = Input.GetAxis ("Vertical");
		float strafe = Input.GetAxis ("Horizontal");
		float rise = Input.mouseScrollDelta.y;

		if (accelerate < 0)
			accelerate *= .5f;
		float rotationX = Input.GetAxis ("Mouse X");
		float rotationY = Input.GetAxis ("Mouse Y");

		rb.transform.Rotate(new Vector3 (-2 * rotationY, 2 * rotationX, 0));
	
		rb.AddRelativeForce(new Vector3(strafe, rise, accelerate )*maxAcc);
	}
}
