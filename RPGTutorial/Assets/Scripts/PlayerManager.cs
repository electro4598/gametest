using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Base_1")
        {
            
            Debug.Log("You take damage");
            GameManager.gameManager.WinLogic();
        }

        else
        {
            Debug.Log(target.name + " collision");
        }
    }
}
