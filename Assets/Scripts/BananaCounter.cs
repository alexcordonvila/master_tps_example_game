using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaCounter : MonoBehaviour {

	public Text countText;
	public GameObject puerta;
	private int count = 0;

	// Use this for initialization
	void Start ()
	{
		countText.text = "Get all the 15 bananas!";
		countText.color = Color.white;
	}

	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Banana"))
		{
			other.gameObject.SetActive(false);

			count = count + 1;

			SetCountText ();
		}
	}
	void SetCountText()
	{
		countText.text = count.ToString();
		countText.color = Color.white;
		if (count >= 15)
		{
			countText.text = "You Win! Go to the Castle!";
			countText.color = Color.white;
			puerta.SetActive(false);
		}
	}
}
