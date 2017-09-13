using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float maxSpeed = 10f;
    public Transform player;
    public Rigidbody2D move; 
    public float rotationSpeed = 5f;

    // Use this for initialization


    void Start () {
        GameObject go = GameObject.Find("player");
        move = GetComponent<Rigidbody2D>();
    }
	   
	// Update is called once per frame
	void FixedUpdate () {
    float moveUpDown = Input.GetAxis("Vertical");
        move.velocity = new Vector2(moveUpDown * maxSpeed * Time.deltaTime, move.velocity.y);
        
    float moveRightLeft = Input.GetAxis("Horizontal");
        move.velocity = new Vector2(moveRightLeft * maxSpeed * Time.deltaTime, move.velocity.x);

        
    }
}
