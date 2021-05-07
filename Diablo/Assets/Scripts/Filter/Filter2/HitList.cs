using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitList : MonoBehaviour
{
    //Here's need to create a method to add GameObject to list
    //We touch a game object & so added to the list in BaseGameObject

    public List<HitList> ToHitList { get; set; }

    public GameObject[] gameObjects; //every item in this table

    public GameObject weapon; //weaponObject in scene
    public bool weaponTriggering; //weapon triggering with wthis object

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this will check if player attack in now trigger with the some thing
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == weapon.name)
        {
            weaponTriggering = true;
        }
    }

    //this will check if player stops triggering
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == weapon.name)
        {
            weaponTriggering = false;
        }
    }
}
