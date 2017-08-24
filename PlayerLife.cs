using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {

    public GameObject power;
    public GameObject power1;
    public GameObject power2;
    public GameObject power3;
    public GameObject power4;
    public GameObject power5;
    

    private int life = 70;
    public Text text;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ZoombieGoli(Clone)" || col.gameObject.name == "Zoombie(Clone)" || col.gameObject.name == "MremirehGoli(Clone)" || col.gameObject.name == "KayaGoli(Clone)")
        {
            life = life - 1;
        }
        if(col.gameObject.name == "Power")
        {
            life = life + 5;
            Destroy(power);
        }
        if (col.gameObject.name == "Power1")
        {
            life = life + 5;
            Destroy(power1);
        }
        if (col.gameObject.name == "Power2")
        {
            life = life + 5;
            Destroy(power2);
        }
        if (col.gameObject.name == "Power3")
        {
            life = life + 5;
            Destroy(power3);
        }
        if (col.gameObject.name == "Power4")
        {
            life = life + 5;
            Destroy(power4);
        }
        if (col.gameObject.name == "Power5")
        {
            life = life + 5;
            Destroy(power5);
        }
        


    }


    private void Update()
    {
        if (life > 0)
        {
            text.text = " " + life;
        }
        else
        {
            text.text = "Game Over";
            Application.LoadLevel(Application.loadedLevel);
        }
    }

}
