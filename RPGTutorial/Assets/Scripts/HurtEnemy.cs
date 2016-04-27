using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour
{
    public int damageToGive;            //Value of the damage 
    public GameObject damageBurst;      //Particle of the damage
    public Transform hitPoint;          //HitPoint of the partical

    //Method which checks collision of the Base with a Player
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Base_1")       //Check if it's an enemy Base
        {
            //If yes it will call Method Hurt from Player Class and will pass a value of a damage
            //that should be done to a Player
            other.gameObject.GetComponent<Base>().Hurt(damageToGive);
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);     //Make a Particle of the damage at certain point
            Debug.Log("Done damage: " + damageToGive);
        }
    }
}