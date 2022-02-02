using UnityEngine;
using UnityEngine.EventSystems;
public class DragCard : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public void OnBeginDrag(PointerEventData eventData)
    {      
        //Removes Card From Current parent
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.root);
        
        //Pointer ignores card by setting it to not block raycasts once picked up
        //Allows for the card to be placed in gametiles
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        //Allows the card to be moved around the screen
        this.transform.position = eventData.position;
    }
  
    public void OnEndDrag(PointerEventData eventData)
    {
        //Place the card on new parent 
        this.transform.SetParent(parentToReturnTo);

        //Card to is able to be picked up again
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}

