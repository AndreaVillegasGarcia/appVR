using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	// Use this for initialization
	void Start () {
     GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0f, 0f, 30f), ForceMode.Impulse);
        Destroy(this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
