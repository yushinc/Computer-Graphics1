using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {   
        // 플래그와 자동차 사이의 거리(= x좌표 차이)
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        string lengthValue = length.ToString("F2");

        // 플래그 이전
        if (length > 0) 
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + lengthValue + "m";

        // length를 소수점 둘째자리까지만 출력하기 때문에 length == 0 으로 하게되면
        // 텍스트가 0.00 이어도 text가 변경되지 않는 상황이 발생한다. 
        // 이를 해결하기 위하여 출력되는 text를 문자열 변수로 생성하여 사용하였다.
        else if (lengthValue.Equals("0.00")) 
            this.distance.GetComponent<Text>().text = "Game Clear";

        // 플래그 지남
        else if (length < 0)
            this.distance.GetComponent<Text>().text = "Game Over";
    }
}
