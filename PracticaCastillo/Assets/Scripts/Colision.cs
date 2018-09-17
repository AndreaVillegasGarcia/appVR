using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour {

	// Use this for initialization


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
        GameObject pelota = other.gameObject;

        if(pelota.CompareTag("Player")){
            
            if (GetComponent<Renderer>().material.color.Equals(Color.blue))
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            }

            else if (GetComponent<Renderer>().material.color.Equals(Color.yellow))
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else if (GetComponent<Renderer>().material.color.Equals(Color.green))
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            else if (GetComponent<Renderer>().material.color.Equals(Color.red))
            {
                Destroy(this.gameObject);
            }

            Destroy(other.gameObject);
        }

	}
}
