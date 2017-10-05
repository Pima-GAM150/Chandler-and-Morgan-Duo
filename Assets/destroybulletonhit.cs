using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybulletonhit : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "BulletPrefab")
        {
            Destroy(col.gameObject);
        }
    }
}