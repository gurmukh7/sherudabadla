using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife2 : MonoBehaviour {

    public int life = 70;
    void OnCollisionEnter(Collision col)
    {
        life = life - 10;
        if (life < 0) { Destroy(gameObject); }
    }
}
