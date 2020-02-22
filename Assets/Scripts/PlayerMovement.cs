using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    public float rotationSpeed;
    Animator anim;
    public Text text;
    public GameObject pressKey;


	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        
        anim.SetBool("IsRunning", z != 0);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject, 1f);
            anim.SetTrigger("Death_Player");
            pressKey.SetActive(true);
        }
    }
   
}
