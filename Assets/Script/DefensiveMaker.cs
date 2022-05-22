using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveMaker : MonoBehaviour
{
    public GameObject DefensivePrefab;
    float currTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;

        if(currTime > 10){
            Defensive_Matrix();
            currTime = 0;
        }
    }
    public void Defensive_Matrix(){
        GameObject Defensive_Matrix = Instantiate(DefensivePrefab);
        //x좌표 난수로 반복
        float x = Random.Range(-8.0f, 9.0f);
            //랜덤한 x좌표에서 생성
        Defensive_Matrix.transform.position = new Vector3(x, -2.19f, 0f);
    }
}
