using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IDropHandler
{
    public static Inventory Instance;
    public GameObject inventory;
    public GameObject outOfInventory;
    public GameObject buttonPrefab;

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
