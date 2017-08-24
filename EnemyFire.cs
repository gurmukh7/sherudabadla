using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float countdown = -1f;

    void Update()
    {
        countdown = countdown - Time.deltaTime;
        if(countdown < 0){
            countdown = 0.2f;
            GameObject bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity =
            bullet.transform.forward * 8;
            Destroy(bullet, 3.0f);
        }
    }

}
