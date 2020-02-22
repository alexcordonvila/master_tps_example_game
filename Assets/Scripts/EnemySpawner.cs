using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;
	public Transform [] enemySpawner;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			int spawnIndex = Random.Range (0, enemySpawner.Length);
			Instantiate (enemy, enemySpawner[spawnIndex].position, enemySpawner[spawnIndex].rotation);

		}
	}
}
