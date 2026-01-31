using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    private Vector3 returnTransform;
    
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public bool inInventory = true;
    
    public Slot slot = null;

    //[SerializeField] private Canvas canvas; 

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>(); 
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    
    
    // OnPointerDown is called when the mose is pressed down
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }

    // Called Every frame of dragging
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
            rectTransform.anchoredPosition += eventData.delta; //canvas.scaleFactor;
    }

    //called at drag start
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        returnTransform = rectTransform.position;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
        if( slot != null)
        {
            slot.Remove();
            slot = null;
        }
        
    }

    //called at drag end
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        if(slot == null)
        {
            rectTransform.position = returnTransform;
        }
        else
        {
            returnTransform = slot.GetComponent<RectTransform>().position;
            rectTransform.position = returnTransform;
        }
    }

    // called on drop
    public void OnDrop(PointerEventData eventData)
    {
    }

    public void LeaveInventory()
    {
        inInventory = false;
        GetComponent<RectTransform>().SetParent(Inventory.Instance.outOfInventory.GetComponent<RectTransform>());
    }

    public void EnterInventory()
    {
        inInventory = false;
        GetComponent<RectTransform>().SetParent(Inventory.Instance.GetComponent<RectTransform>());
    }
}