using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}
	
	// Update is called every frame but guarantees that all others have run
	void LateUpdate () {
		float desiredAngle = target.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler (0, desiredAngle, 0);
		transform.position = target.transform.position + (rotation * offset);
		transform.LookAt (target.transform);
	}
}
