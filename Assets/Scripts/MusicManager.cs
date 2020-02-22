using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour {

	public static MusicManager instance;

	public int enemyCount = 0;

	void Awake ()
	{
		if (instance != null)
			{
				Destroy (gameObject);
			}
			instance = this;
	}

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (enemyCount > 0)
		{
			EnemyIn();
		}
		else
		{
			NoEnemies();
		}

	}
	public void EnemyIn ()
	{
		print("There are enemies following you");
	}

	public void NoEnemies ()
	{
		print("No more enemies around");
	}
}
