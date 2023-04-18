using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0; // ȸ�� �ӵ�
    bool click = false; // ���� / ������ ��ư ���� �ο� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư Ŭ��
        {
            this.rotSpeed = 30;
            click = false;
        }
        else if (Input.GetMouseButtonDown(1)) // ���콺 ������ ��ư Ŭ��
        {
            this.rotSpeed = 30;
            click = true;
        }
        else if (Input.GetMouseButtonDown(2)) // ���콺 �� ��ư Ŭ��
        {
            this.rotSpeed = 0; // ȸ�� ������ 0���� �ٿ� �ٹ�ư Ŭ�� �� �ٷ� ���ߵ���
            click = false;
        }

        if (click)
        {
            this.rotSpeed *= 0.96f;
            transform.Rotate(0, 0, this.rotSpeed); // z�� �������� �����Ӵ� ȸ�� ���� �����ϸ� ȸ��
        } else
        {
            transform.Rotate(0, 0, this.rotSpeed); // z�� �������� �����Ӵ� rotSpeed ������ ȸ��
        }
    }
}
