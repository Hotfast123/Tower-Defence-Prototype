using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Towers : MonoBehaviour
{
    [Header("Turret Options")]
    public GameObject bullet;
    public GameObject laser;
    public GameObject missle;
    public GameObject minner;

    public Transform towerSpawnPoint;
    public GameObject GameTileDelted;
    public Shake Shake;

    public string towerType;
    bool LoopOnce = true;

    void Update()
    {
        //Creates tower once
        if(LoopOnce == true)
        {
            //If the game tile is deleted create a tower
            if (GameTileDelted == null)
            {
                //Finds the text written in a UI element
                Text textBox = GameObject.Find("Canvas/TowerText").GetComponent<Text>();
                towerType = textBox.text;

                //Compares the text
                if (towerType == ("BulletTurret(Clone)"))
                {
                    //Creates the tower at a hight and shakes the sceen
                    Instantiate(bullet, towerSpawnPoint);
                    StartCoroutine(Shake.CameraShake(.15f, .4f));
                    LoopOnce = false;                
                }
                else if (towerType == ("Missles(Clone)"))
                {
                    Instantiate(missle, towerSpawnPoint);
                    StartCoroutine(Shake.CameraShake(.15f, .4f));
                    LoopOnce = false;
                }
                else if (towerType == ("LasersTurret(Clone)"))
                {
                    Instantiate(laser, towerSpawnPoint);
                    StartCoroutine(Shake.CameraShake(.15f, .4f));
                    LoopOnce = false;
                }
                else if (towerType == ("Miner(Clone)"))
                {
                    Instantiate(minner, towerSpawnPoint);
                    StartCoroutine(Shake.CameraShake(.15f, .4f));
                    LoopOnce = false;
                }             
            }
        }       
    }
}



  
