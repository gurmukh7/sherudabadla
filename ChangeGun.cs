using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGun : MonoBehaviour {

    public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;
	// Use this for initialization
	void Start () {
        gun1.SetActive(true);
        gun2.SetActive(false);
        gun3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1"))
        {
            gun1.SetActive(true);
            gun2.SetActive(false);
            gun3.SetActive(false);
        }

        if (Input.GetKeyDown("2"))
        {
            gun1.SetActive(false);
            gun2.SetActive(true);
            gun3.SetActive(false);
        }

        if (Input.GetKeyDown("3"))
        {
            gun1.SetActive(false);
            gun2.SetActive(false);
            gun3.SetActive(true);
        }
    }
}
