using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToHitGameObject 
{
    //File to ToHitGameObject List of Objects
    public GameObject ToHhit { get; set; }

    public ToHitGameObject(GameObject toToHit)
    {
        this.ToHhit = toToHit;
        Debug.Log("New ToHit added!");
    }
}
