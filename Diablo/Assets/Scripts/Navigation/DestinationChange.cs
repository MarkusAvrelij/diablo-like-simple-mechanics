using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationChange : MonoBehaviour
{
    public int xPos;
    public int zPos;
    //public int yPos;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CrusadesBastionNPC")
        {
            xPos = Random.Range(-840, -857);
            zPos = Random.Range(-340, -361);
            this.gameObject.transform.position = new Vector3(xPos, 171.8f, zPos);
        }
        if (other.tag == "ARSGothikaNPC")
        {
            xPos = Random.Range(-136, -221);
            zPos = Random.Range(-845, -847);
            this.gameObject.transform.position = new Vector3(xPos, 482.5f, zPos);
        }
        if (other.tag == "CelestialNPC")
        {
            xPos = Random.Range(-137, -125);
            zPos = Random.Range(-200, -220);
            this.gameObject.transform.position = new Vector3(xPos, 124f, zPos);
        }
    }
}
