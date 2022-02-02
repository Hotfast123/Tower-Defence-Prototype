using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardPowers : MonoBehaviour
{
    public string cardName;

    void Update()
    {
        if (transform.parent.tag == "GameTile")
        {
            Text textBox = GameObject.Find("Canvas/TowerText").GetComponent<Text>();
            cardName = gameObject.name;
            textBox.text = cardName;

            if (cardName == ("BulletTurret(Clone)"))
            {
                if (GameObject.FindObjectOfType<Money>().money >= 40)
                {
                    GameObject.FindObjectOfType<Money>().subtractMoney(40);
                    Destroy(transform.parent.gameObject);
                }
            }
            else if (cardName == ("Missles(Clone)"))
            {
                if (GameObject.FindObjectOfType<Money>().money >= 80)
                {
                    GameObject.FindObjectOfType<Money>().subtractMoney(80);
                    Destroy(transform.parent.gameObject);
                }
            }
            else if (cardName == ("LasersTurret(Clone)"))
            {
                if (GameObject.FindObjectOfType<Money>().money >= 60)
                {
                    GameObject.FindObjectOfType<Money>().subtractMoney(60);
                    Destroy(transform.parent.gameObject);
                }
            }
            else if (cardName == ("Miner(Clone)"))
            {
                if (GameObject.FindObjectOfType<Money>().money >= 25)
                {
                    GameObject.FindObjectOfType<Money>().subtractMoney(25);
                    Destroy(transform.parent.gameObject);
                }
            }
            Destroy(gameObject);
            cardName = "nothing";
        }                                  
    }
}
