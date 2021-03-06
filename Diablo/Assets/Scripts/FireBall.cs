using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Vector3 Direction { get; set; }
    public float Range { get; set; }
    public int Damage { get; set; }

    Vector3 spawnPosition;

    void Start()
    {
        Range = 20f;
        Damage = 40;
        spawnPosition = transform.position;
        GetComponent<Rigidbody>().AddForce(Direction * 100f);
    }

    void Update()
    {
        if (Vector3.Distance(spawnPosition, transform.position) >= Range)
        {
            Extinguish();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "Enemy")
        {
            col.transform.GetComponent<IEnemy>().TakeDamage(Damage);
        }
        Extinguish();
    }
    void Extinguish()
    {
        //here i can put how the fireball will be destroy trigger/animation
        Destroy(gameObject);
    }
}
