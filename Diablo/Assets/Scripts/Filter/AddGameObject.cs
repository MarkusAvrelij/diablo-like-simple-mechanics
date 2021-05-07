using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGameObject : MonoBehaviour
{

    //Here's need to create a method to add GameObject to list
    //We touch a game object & so added to the list in BaseGameObject


    public GameObject[] gameObjects; //every item in this table

    public GameObject weapon; //weaponObject in scene
    public bool weaponTriggering; //weapon triggering with wthis object




    //this will check if player attack in now trigger with the some thing
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == weapon.name)
        {
            weaponTriggering = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == weapon.name)
        {
            weaponTriggering = false;
        }
    }
}
