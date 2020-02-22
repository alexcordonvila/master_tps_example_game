using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour {

	public GameObject startPosition;
	public Animator anim;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		// Aquí disparamos apretando Space
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate (Resources.Load ("Projectile"), startPosition.transform.position, transform.rotation);

			anim.SetTrigger ("Attack");
		}
	}
}
