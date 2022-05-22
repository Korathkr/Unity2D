using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject shield;
    // Start is called before the first frame update
    void Start()
    {
        shield = GameObject.Find("Shield");
        shield.GetComponent<Image>().fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
