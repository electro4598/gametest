using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    private Base castleBase;
    // Use this for initialization
    void Start()
    {
        castleBase = GetComponent<Base>();
    }
	
	// Update is called once per frame
    

    public void WinLogic()
    { 
        if(castleBase.tag == "Base_1") 
        if (castleBase.currentHealth <= 0)
        {
            Debug.Log("You loose");
        }
            /*       if (GameObject.FindGameObjectWithTag("Base_1").GetComponent<Base>().currentHealth <= 0)
        {
            Debug.Log("Loose");
            Debug.Log("Base_2 Wins");
        } else if (GameObject.FindGameObjectWithTag("Base_2").GetComponent<Base>().currentHealth <= 0)
        {
            Debug.Log("Loose");
            Debug.Log("Base_1 Wins");
        }*/
    }
}