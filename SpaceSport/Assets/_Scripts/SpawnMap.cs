using UnityEngine;
using System.Collections;

public class SpawnMap : MonoBehaviour {

	public GameObject barPrefab;
	public GameObject capPrefab;
	public GameObject seeker;
	//public GameObject goal;
	//public GameObject obstacle;
	public int feildDiameter;
	public int feildLength;

	// Use this for initialization
	void Start () {
		barPrefab.transform.localScale = new Vector3(1f, 1f, (float)(feildLength));
		capPrefab.transform.localScale = new Vector3 (2f*(float)feildDiameter, 2f*(float)feildDiameter, 1f);
		for (float i = 0f; i < 2 * Mathf.PI; i += 10*1/(2 * Mathf.PI * feildDiameter)) {
			Instantiate(barPrefab, new Vector3(Mathf.Cos(i) *(float)feildDiameter,(Mathf.Sin(i)*(float)feildDiameter), 0f), Quaternion.identity);
		}
		Instantiate (capPrefab, new Vector3 (0f, 0f, (float)(100 * feildLength)), Quaternion.identity);
		Instantiate (capPrefab, new Vector3 (0f, 0f, (float)(-100 * feildLength)), Quaternion.identity);
	
		Instantiate (seeker, new Vector3 (10f, 10f, 10f), Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
// 312 413 7059 Maria Cortez -- Loans