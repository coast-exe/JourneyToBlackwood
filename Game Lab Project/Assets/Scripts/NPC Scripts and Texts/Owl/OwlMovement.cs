﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlMovement : MonoBehaviour {

    public Rigidbody2D player;

    public Rigidbody2D rb;

    public SpriteRenderer sprite;

    //Distance owl is above player
    public float owlHeight = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (player.velocity.x > 0 && player.position.x > rb.position.x + 3)
        {
            rb.velocity = new Vector2(player.velocity.x, 0);
            sprite.flipX = true;
        } else if (player.velocity.x < 0 && player.position.x < rb.position.x - 3)
        {
            rb.velocity = new Vector2(player.velocity.x, 0);
            sprite.flipX = false;
        } else if (player.velocity.x == 0 && rb.velocity.x != 0)
        {
            new WaitForSeconds(2);
            rb.velocity = new Vector2(0, 0);
        }

        rb.position = new Vector2(rb.position.x, player.position.y + owlHeight);

        if(Mathf.Abs(player.position.x - rb.position.x) > 20)
        {
            rb.position = new Vector2(player.position.x, player.position.y + owlHeight);
        }
    }
}
