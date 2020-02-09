using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	public float speed;
	private Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate()
	{
		float moveHoryzont = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3 (moveHoryzont, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}

}
