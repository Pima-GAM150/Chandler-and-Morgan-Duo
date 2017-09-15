using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public float bulletSpeed = 0f;
    public GameObject bulletPrefab;
    private List<GameObject> projectiles = new List<GameObject>();
    public Collider2D enemyPreFab;
    // Use this for initialization
    void Start() {
       

    }

    // Update is called once per frame
    void Update()
    {
        
      
        

        if (Input.GetMouseButtonDown (0))
        {
            GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            projectiles.Add(bullet);
            
        }
        for (int i = 0; i < projectiles.Count; i++)
        {
            GameObject shootBullet = projectiles[i];
            if (shootBullet != null)
            {
                Vector2 bulletScreenPos = (shootBullet.transform.position);
                
                //deleting the prefab
                if (bulletScreenPos.y >= Screen.width || bulletScreenPos.y <=0 )
                {
                    DestroyObject(shootBullet);
                    projectiles.Remove(shootBullet);
                }
               
                
            }
        }



    }
    }
