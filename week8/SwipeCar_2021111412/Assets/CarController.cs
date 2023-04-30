using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos; // 프레임 업데이트 시 초기화되지 않게 하려고 전역변수로 선언

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // 마우스를 클릭한 지점의 좌표 startPos 변수에 저장
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) {
            // 마우스를 뗀 지점의 좌표 endPos 변수에 저장
            Vector2 endPos = Input.mousePosition;

            // 스와이프 길이를 구한다.
            float swipeLength = endPos.x - startPos.x;

            // 이동할 거리를 스와이프 길이로 변경한다.
            this.speed = swipeLength / 500.0f;

            // 이동할 때만 효과음을 재생한다.
            GetComponent<AudioSource>().Play();
        }

        // Translate는 현재 좌표에서 인수 값만큼 이동시키는 메서드, x축방향으로 this.speed 만큼 움직임
        // speed가 양수일 때만 이동가능, 즉 오른쪽으로만 이동 가능
        if (this.speed > 0)
        {
            transform.Translate(this.speed, 0, 0);
            this.speed *= 0.98f;
        }
    }
}
