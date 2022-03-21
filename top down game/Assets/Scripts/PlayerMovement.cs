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

	private Animator anim;


    //Dash variables



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
		
    }


    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
		float y = Input.GetAxisRaw("Vertical");
        
        Vector2 moveInput = new Vector2(x, y);
        rb.velocity = moveInput * speed * Time.deltaTime;
        if(moveInput != Vector2.zero)
		{
			anim.SetFloat("XInput", x);
			anim.SetFloat("YInput", y);

		}
    }
    

}
