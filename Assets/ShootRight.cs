using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRight : MonoBehaviour {

    public GameObject bullet;
    public float bulletSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bullet.transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }
}

