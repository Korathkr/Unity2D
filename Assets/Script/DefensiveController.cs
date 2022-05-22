using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefensiveController : MonoBehaviour{

    public GameObject shield;
    public GameObject def;

    // Start is called before the first frame update
    void Start()
    {
        shield = GameObject.Find("Shield");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "ROBOT"){
            shield.GetComponent<Image>().fillAmount = 1;
            Destroy(def);
        }
    }

    void OnCollisionEnter2D(Collision2D Col){
        if(Col.gameObject.tag == "ROBOT"){
            shield.GetComponent<ShieldController> ().getDefensive();
        }
        Destroy(gameObject);    
        if(shield.GetComponent<Image>().fillAmount <= 0){
            shield.gameObject.SetActive(false);
        }
    }
}
