using UnityEngine;
using System.Collections;

public class TargetHelper : MonoBehaviour {

	private const float timeConst = 0.2f;


		
	public static Vector3 getPositionIn (Rigidbody rb, float time){
		Vector3 speedDir = rb.velocity;
		return rb.position + new Vector3(speedDir.x*timeConst*time, speedDir.y*timeConst*time,
			speedDir.z*timeConst*time); //new Vector3(timeConst, timeConst, timeConst);
	}

	public static GameObject findClosestPlayer(Rigidbody rb, float time){
		return findClosest("Player", getPositionIn(rb, time));
	}

	private static GameObject findClosest(string tag, Vector3 position){
		float nearestDist = Mathf.Infinity;
		GameObject ret = null;
		GameObject[] objects = GameObject.FindGameObjectsWithTag (tag);
		foreach (GameObject obj in objects){
			float dist = (obj.transform.position - position).sqrMagnitude;
			if (dist < nearestDist){
				nearestDist = dist;
				ret = obj;
			}
		}
		return ret;
	}
}
