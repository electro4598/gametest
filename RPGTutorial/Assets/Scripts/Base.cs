using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour
{
    public int health;          //Health of the base
    public int currentHealth;   //Current health of the base


    //Getters and Setters for health and currentHealth
    public int getHealth()
    {
        return health;
    }

    public void setHealth(int health)
    {
        this.health = health;
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }

    public void setCurrentHealth(int currentHealth)
    {
        this.currentHealth = currentHealth;
    }


    //Initializing that currentHealth is equal to the health of the base
    void Start ()
	{
        setCurrentHealth(getHealth());
        //currentHealth = health;
    }

    //Method where damage done to the base is calcualted
    public void Hurt(int damageToGive)
    {
        setCurrentHealth(getCurrentHealth()-damageToGive);
        //currentHealth -= damageToGive;
    }
}
