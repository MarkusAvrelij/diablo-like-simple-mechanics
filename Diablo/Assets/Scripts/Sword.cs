using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{

    private Animator animator;
    public List<BaseStat> Stats { get; set; }
    public CharacterStats CharacterStats { get; set; }
    public int CurrentDamage { get; set; }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PerformAttack(int damage)
    {
        CurrentDamage = damage;
        animator.SetTrigger("Base_Attack");
        Debug.Log(this.name + " attack!");
    }

    public void PerformSpecialAttack()
    {
        animator.SetTrigger("Special_Attack");
        Debug.Log(this.name + " attack!");
    }

    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Hit: " + col.name);
        if (col.tag == "Enemy")
        {
            col.GetComponent<IEnemy>().TakeDamage(CurrentDamage);
        }
    }
}
