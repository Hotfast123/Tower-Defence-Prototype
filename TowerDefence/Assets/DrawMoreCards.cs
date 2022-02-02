using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawMoreCards : MonoBehaviour
{
    public Transform spawnPoint;
    int randomInt;

    private int moneyamount = 25;

    public GameObject[] card;

    public Money money;



    public void PressedButton()
    {
        if (money.money >= moneyamount)
        {
            money.subtractMoney(moneyamount);
            randomInt = Random.Range(0, card.Length);
            Instantiate(card[randomInt], spawnPoint);
            moneyamount += 15;
            Text textBox = GameObject.Find("Canvas/Card Hand/Button Draw /MoneyAmount").GetComponent<Text>();
            textBox.text = moneyamount.ToString();
        }
    }
}

