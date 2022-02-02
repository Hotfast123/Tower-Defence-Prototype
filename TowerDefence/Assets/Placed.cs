using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Placed : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Needed for OnDrop to work
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //Needed for OnDrop to work
    }
    public void OnDrop(PointerEventData eventData)
    {  
        //Gets the data from the drag event and if it comes back that a card is over a Game Tile
        DragCard d = eventData.pointerDrag.GetComponent<DragCard>();

        if (d != null)
        {
            //Set the card new parent 
            d.parentToReturnTo = this.transform;
        }
    }
}
