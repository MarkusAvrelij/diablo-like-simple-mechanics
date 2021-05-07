using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotToHitGameObject
{
    //File to NotToHitGameObject List of Objects
    public GameObject NotToHhit { get; set; }
   

    public NotToHitGameObject(GameObject notToHit)
    {
        this.NotToHhit = notToHit;
        Debug.Log("New NotToHit added!");
    }
}
