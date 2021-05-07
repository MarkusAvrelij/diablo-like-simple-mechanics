using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour, IWeapon, IProjectileWeapon
{

    private Animator animator;
    public List<BaseStat> Stats { get; set; }
    public int CurrentDamage { get; set; }
    public Transform ProjectileSpawn { get; set;  }
    FireBall fireball;

    void Start()
    {
        fireball = Resources.Load<FireBall>("Weapons/Projectiles/Fireball");
        animator = GetComponent<Animator>();
    }

    public void PerformAttack(int damage)
    {

        animator.SetTrigger("Base_Attack");
        Debug.Log(this.name + " attack!");
    }

    public void PerformSpecialAttack()
    {
        animator.SetTrigger("Special_Attack");
        Debug.Log(this.name + " attack!");
    }

    /*
     private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Hit: " + col.name);
        if (col.tag == "Enemy")
        {
            col.GetComponent<IEnemy>().TakeDamage(Stats[0].GetCalculatedStatValue());
        }
    }
         */

    public void CastProjectile()
    {
        FireBall fireballInstance = (FireBall)Instantiate(fireball, ProjectileSpawn.position, ProjectileSpawn.rotation);
        fireballInstance.Direction = ProjectileSpawn.forward;
    }
}
