using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {

    public Transform pelota;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            Instantiate(pelota, transform.position, transform.rotation);
        }

	}
}
