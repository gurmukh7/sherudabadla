using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheGate : MonoBehaviour {

    public GameObject gate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gate);
    }
}
