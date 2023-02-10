using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
	public Rigidbody rb;
	public bool intoJump;
	private bool goingRight;
	private bool goingLeft;
	private bool isRunning;
	private int tmp;
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("Tqt Start");
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			intoJump = true;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			goingLeft = true;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			goingRight = true;
		}
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			isRunning = true;
		}
	}

	private void FixedUpdate()
	{
		tmp = isRunning ? 6 : 3;
		if (intoJump)
		{
			rb.AddForce(Vector3.up * tmp, ForceMode.VelocityChange);
			intoJump = false;
			isRunning = false;
		}
		if (goingRight)
		{
			rb.AddForce(Vector3.right * tmp, ForceMode.VelocityChange);
			goingRight = false;
			isRunning = false;

		}
		if (goingLeft)
		{
			rb.AddForce(Vector3.right * -tmp, ForceMode.VelocityChange);
			goingLeft = false;
			isRunning = false;
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
	}
}