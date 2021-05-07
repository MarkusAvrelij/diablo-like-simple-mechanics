using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUi : MonoBehaviour
{
    public RectTransform inventoryPanel;
    public RectTransform scrollViewContent;
    InventoryUIItem itemContainer { get; set; }
    bool menuIsActive { get; set; }
    Item currentSelectedItem { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        itemContainer = Resources.Load<InventoryUIItem>("Ui/Item_Container");
        UIEventHandler.OnItemAddedToInventory += ItemAdded;
        inventoryPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            menuIsActive = !menuIsActive;
            inventoryPanel.gameObject.SetActive(menuIsActive);
        }
    }

    public void ItemAdded(Item item)
    {
        InventoryUIItem emptyItem = Instantiate(itemContainer);
        emptyItem.SetItem(item);
        emptyItem.transform.SetParent(scrollViewContent);
    }
}
