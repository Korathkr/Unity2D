using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dynamiteController : MonoBehaviour
{
    GameObject shield;
    private GameObject hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("HP");
        shield = GameObject.Find("Shield");
    }

    // Update is called once per frame
    void Update() 
    {

    }
    void OnCollisionEnter2D(Collision2D Col){
        if(Col.gameObject.tag=="ROBOT" && shield.GetComponent<Image>().fillAmount > 0)
        {

            shield.GetComponent<Image>().fillAmount -=0.25f;
        }
        else if(Col.gameObject.tag=="ROBOT")
        {

            hp.GetComponent<Image>().fillAmount -=0.25f;
        }
        Destroy(gameObject);
        }
    }
