using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {
    
    public Text text;
    private int Score;

    private void Start()
    {
        Score = 1;
    }

    private void OnCollisionEnter(Collision col)
    {

        
        if (col.gameObject.name == "Goli1(Clone)")
        {
            Score = Score + 5;

        }
    }


    // Update is called once per frame
    void Update () {
        text.text = "" + Score;
    }

    
}
