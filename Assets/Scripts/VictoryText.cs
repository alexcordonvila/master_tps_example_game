using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryText : MonoBehaviour {

    public Text text;

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            text.text = "Thanks for playing!";            
        }        
    }
}
