using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLife1 : MonoBehaviour
{


    public int life = 40;
    void OnCollisionEnter(Collision col)
    {
        life = life - 10;
        if (life < 0)
        {
            Destroy(gameObject);


        }

    }
}
