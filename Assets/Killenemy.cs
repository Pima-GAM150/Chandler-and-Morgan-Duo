using System.Collections;
using UnityEngine;

public class Killenemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Enemy")
        {
            Destroy(col.gameObject);

        }
    }
}
