using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos; // ������ ������Ʈ �� �ʱ�ȭ���� �ʰ� �Ϸ��� ���������� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // ���콺�� Ŭ���� ������ ��ǥ startPos ������ ����
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) {
            // ���콺�� �� ������ ��ǥ endPos ������ ����
            Vector2 endPos = Input.mousePosition;

            // �������� ���̸� ���Ѵ�.
            float swipeLength = endPos.x - startPos.x;

            // �̵��� �Ÿ��� �������� ���̷� �����Ѵ�.
            this.speed = swipeLength / 500.0f;

            // �̵��� ���� ȿ������ ����Ѵ�.
            GetComponent<AudioSource>().Play();
        }

        // Translate�� ���� ��ǥ���� �μ� ����ŭ �̵���Ű�� �޼���, x��������� this.speed ��ŭ ������
        // speed�� ����� ���� �̵�����, �� ���������θ� �̵� ����
        if (this.speed > 0)
        {
            transform.Translate(this.speed, 0, 0);
            this.speed *= 0.98f;
        }
    }
}
