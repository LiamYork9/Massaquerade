using JetBrains.Annotations;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    public string itemName;
    public Item item;

    public Mask mask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUpItem()
    {
        Inventory.Instance.AddItem(item);
    }
    
    public void RemoveItem()
    {
        Destroy(gameObject);
    }
}
