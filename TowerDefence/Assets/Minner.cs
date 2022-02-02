using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minner : MonoBehaviour
{
    private bool activateMoney = true;
    void Start()
    {       
        StartCoroutine(MakingMoney());        
    }

    public IEnumerator MakingMoney()
    {
        //Creates money for the player every 25 secounds 
        while(activateMoney == true)
        {
            GameObject.FindObjectOfType<Money>().addMoney(35);
            yield return new WaitForSeconds(25f);
        }
    }

}
