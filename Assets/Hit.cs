using System.Collections;
using UnityEngine;

public class Hit : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
          
        }
    }
}
