using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public GameObject playerHand;
    public GameObject EquippedWeapon { get; set; }

    Transform spawnProjectile;
    Item currentlyEquippedItem;
    IWeapon equippedWeapon;
    CharacterStats characterStats;

    void Start()
    {
        spawnProjectile = transform.Find("ProjectileSpawn");
        characterStats = GetComponent<Player>().characterStats;
    }
    public void EquipWeapon(Item itemToEquip)
    {
        if(EquippedWeapon != null)
        {
            UnequipWeapon();
        }
        EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/" + itemToEquip.ObjectSlug),
            playerHand.transform.position, playerHand.transform.rotation);

        equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
         if(EquippedWeapon.GetComponent<IProjectileWeapon>() != null) 
            EquippedWeapon.GetComponent<IProjectileWeapon>().ProjectileSpawn = spawnProjectile;
        //equippedWeapon.Stats = itemToEquip.Stats;
        EquippedWeapon.transform.SetParent(playerHand.transform);
        equippedWeapon.Stats = itemToEquip.Stats;
        currentlyEquippedItem = itemToEquip;
        characterStats.AddStatBonus(itemToEquip.Stats);
        UIEventHandler.ItemEquipped(itemToEquip);
        UIEventHandler.StatsChanged();
    }

    public void UnequipWeapon()
    {
        InventoryController.Instance.GiveItem(currentlyEquippedItem.ObjectSlug);
        characterStats.RemoveStatBonus(equippedWeapon.Stats);
        Destroy(EquippedWeapon.transform.gameObject);
        UIEventHandler.StatsChanged();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PerformWeaponAttack();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            PerformWeaponSpecialAttack();
        }
    }

    public void PerformWeaponAttack()
    {
        equippedWeapon.PerformAttack(CalculateDamage());
    }
    public void PerformWeaponSpecialAttack()
    {
        equippedWeapon.PerformSpecialAttack();
    }

    //here's a critical damage calculating
    private int CalculateDamage()
    {
        int damageToDeal = ((characterStats.GetStat(BaseStat.BaseStatType.Power).GetCalculatedStatValue()*2)
            +Random.Range(2,8));
        damageToDeal += CalculateCrit(damageToDeal);
        Debug.Log("Damage dealt: " + damageToDeal);
        return damageToDeal;
    }
    private int CalculateCrit(int damage)
    {
        if(Random.value <= .10f)
        {
            int critDamage = (int)(damage * Random.Range(.25f, .5f));
            return critDamage;
        }
        return 0;
    }
}
