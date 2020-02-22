using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PressKeyToRestart : MonoBehaviour
{
	public Text text;

	void Update ()
	{
		text.text = "Press key to restart";
		
		if (Input.anyKeyDown)
		{
			// cargamos la escena actualmente activa
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
