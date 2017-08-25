using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float maxSpeed = 10f;
    public Transform player;
    public Rigidbody2D move;

    // Use this for initialization


    void Start () {
        GameObject go = GameObject.Find("player");
        move = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
    float moveUpDown = Input.GetAxis("Vertical");
        move.velocity = new Vector2(moveUpDown * maxSpeed, move.velocity.x);
        
float moveRightLeft = Input.GetAxis("Horizontal");
        move.velocity = new Vector2(moveRightLeft * maxSpeed, move.velocity.x);
        
	}
}
