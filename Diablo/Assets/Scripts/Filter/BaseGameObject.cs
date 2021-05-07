using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGameObject{
    public List<AddGameObject> AddedGameObject { get; set; }//here's we added a gameObject's what we touched to list.
    public List<NotToHitGameObject> NotToHitGameObjects { get; set; }//Here's we transfer gameObjects, which cannot hit
    public List<ToHitGameObject> ToHitGameObjects { get; set; }//Here's we transfer gameObjects, which can hit
    public string GameObjectName { get; set; }

    public BaseGameObject()
    {

    }

    public void FilterGameObjects()
    {
        
    }
}
