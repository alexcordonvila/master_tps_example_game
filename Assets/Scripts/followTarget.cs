using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followTarget : MonoBehaviour {
	Animator animator;
	NavMeshAgent agent;
	public Transform target;
	public GameObject player;
	Collider col;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindWithTag("Player");
		target = player.transform;
		animator = GetComponent<Animator>();
		agent = GetComponent<NavMeshAgent>();
		col = GetComponent<CapsuleCollider>();
	}

	// Update is called once per frame
	void Update ()
	{
        if (target)
		    agent.SetDestination(target.transform.position);

	}
	// Aquí se destruye el enemigo y muere
	private void OnTriggerEnter(Collider other) {

		if (other.tag == "Bullet")
		{
			col.enabled = false;
			Destroy (gameObject, 2.5f);
			animator.SetTrigger("Death");
		}
	}
}
