using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public float bulletSpeed = 0f;
    public GameObject bulletPrefab;
    private List<GameObject> projectiles = new List<GameObject>();

    // Use this for initialization
    void Start() {
       

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            projectiles.Add(bullet);
        }
        for (int i = 0; i < projectiles.Count; i++)
        {
            GameObject shootBullet = projectiles[i];
            if (shootBullet != null)
            {
                shootBullet.transform.Translate(new Vector3(direction.x,direction.y) * bulletSpeed * Time.deltaTime);
            }
        }



    }
    }
