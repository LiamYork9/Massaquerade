using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{ 
       public GameObject contents = null;
       public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("OnDrop");
            if (eventData.pointerDrag != null && contents == null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                contents = eventData.pointerDrag;
                contents.GetComponent<DragAndDrop>().LeaveInventory();
                contents.GetComponent<DragAndDrop>().slot = gameObject.GetComponent<Slot>();
                Player.Instance.mask = contents.GetComponent<ItemHolder>().mask;
            }
        }
        public void Remove()
        {
            if(contents != null)
        {
            Player.Instance.mask = Mask.Default;
        }
            contents = null;
        }


}
