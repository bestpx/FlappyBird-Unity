using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var pos = transform.position;
		pos.x -= Time.deltaTime * speed;
		transform.position = pos;
	}
}
