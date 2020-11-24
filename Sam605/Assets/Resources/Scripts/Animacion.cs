using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Animacion : MonoBehaviour
{

	public float speed = 3f;
	public float turnSpeed = .1f;

	public Animator anim;
	public bool canMove;

    void Update()
    {
		canMove = false;
		if(Input.GetKeyDown(KeyCode.Space)){
			canMove = true;
		}
		float strafe = Input.GetAxis("Horizontal");
		float forward = Input.GetAxis("Vertical");
		

		transform.Translate( new Vector3(strafe, 0, forward) * Time.deltaTime * speed );

		float turn = Input.GetAxis("Mouse X");

		transform.rotation *= Quaternion.Slerp( Quaternion.identity, Quaternion.LookRotation(turn < 0 ? Vector3.left : Vector3.right), Mathf.Abs(turn) * Time.deltaTime * turnSpeed);

		anim.SetFloat( "Right", strafe );
		anim.SetFloat( "Forward", forward );
		anim.SetBool( "CanMove", canMove );
    }
    
}