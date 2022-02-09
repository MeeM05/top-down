using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	//Component references, stuff like Rigidbody, animator, and SpriteRenderer go in here
	public Rigidbody2D rb;


    //Movement variables
    private float horizVelocity;
    private float vertVelocity; 
	public float speed = 4f;


    //Dash variables



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveH();
		MoveV();
    }


    void MoveH()
    {
        float x = Input.GetAxisRaw("Horizontal");
        horizVelocity = x * speed;
        rb.velocity = new Vector2(horizVelocity, rb.velocity.y);

    }
    void MoveV()
	{
		float y = Input.GetAxisRaw("Vertical");
		vertVelocity = y * speed;
		rb.velocity = new Vector2(vertVelocity, rb.velocity.x);
	}

}
