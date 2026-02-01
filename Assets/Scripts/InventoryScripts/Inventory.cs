using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Inventory : MonoBehaviour, IDropHandler
{
    public static Inventory Instance;
    public GameObject inventory;
    public GameObject outOfInventory;
    public GameObject buttonPrefab;

    public List<Item> maskList;

    void Awake()
    {
        if (Inventory.Instance != this && Inventory.Instance != null)
        {
            Destroy(TextBoxManager.Instance);
            Instance = this;
        }
        else
        {
            Instance = this;
        }
        if(Instance == this)
        {
            for(int i = 0; i< maskList.Count;i++)
            {
                AddItem(maskList[i]);
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(Item item)
    {
        GameObject btn = Instantiate( Inventory.Instance.buttonPrefab,  Inventory.Instance.inventory.transform);
        btn.GetComponentInChildren<TMP_Text>().text = item.itemName;
        btn.GetComponentInChildren<ItemHolder>().itemName = item.itemName;
        btn.GetComponentInChildren<ItemHolder>().item = item;
        btn.GetComponentInChildren<Image>().sprite = item.sprite;
        btn.GetComponentInChildren<ItemHolder>().mask = item.mask;
        //btn.GetComponentInChildren<Button>().onClick.AddListener((() => { btn.GetComponentInChildren<ItemHolder>().RemoveItem(); }));
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnInventoryDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragAndDrop>().EnterInventory();
            eventData.pointerDrag.GetComponent<DragAndDrop>().slot = null;
        }
    }

}
