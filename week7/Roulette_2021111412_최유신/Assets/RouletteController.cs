using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0; // 회전 속도
    bool click = false; // 왼쪽 / 오른쪽 버튼 구분 부울 변수

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭
        {
            this.rotSpeed = 30;
            click = false;
        }
        else if (Input.GetMouseButtonDown(1)) // 마우스 오른쪽 버튼 클릭
        {
            this.rotSpeed = 30;
            click = true;
        }
        else if (Input.GetMouseButtonDown(2)) // 마우스 휠 버튼 클릭
        {
            this.rotSpeed = 0; // 회전 각도를 0으로 줄여 휠버튼 클릭 시 바로 멈추도록
            click = false;
        }

        if (click)
        {
            this.rotSpeed *= 0.96f;
            transform.Rotate(0, 0, this.rotSpeed); // z축 방향으로 프레임당 회전 각도 감소하며 회전
        } else
        {
            transform.Rotate(0, 0, this.rotSpeed); // z축 방향으로 프레임당 rotSpeed 각도로 회전
        }
    }
}
