using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : Interactable
{
    public Item ItemDrop { get; set; }
    public override void Interact()
    {
        InventoryController.Instance.GiveItem(ItemDrop); //rabotaet cherez vtorj GiveItem v inventorycontroller itemitem a ne itemslug
        Destroy(gameObject);
    }
}
