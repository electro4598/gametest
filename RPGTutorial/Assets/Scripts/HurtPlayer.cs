using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive;    //Value of the damage 

    //Method which checks collision of the Base with a Player
    void OnCollisionEnter2D(Collision2D other)
    //void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")       //Check if it's a player
        {
            //If yes it will call Method Hurt from Player Component and will pass a value of a damage
            //that should be done to a Player
            other.gameObject.GetComponent<Player>().Hurt(damageToGive);
        }
    }
}
