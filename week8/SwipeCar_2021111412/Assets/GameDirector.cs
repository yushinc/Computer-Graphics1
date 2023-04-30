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
        // �÷��׿� �ڵ��� ������ �Ÿ�(= x��ǥ ����)
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        string lengthValue = length.ToString("F2");

        // �÷��� ����
        if (length > 0) 
            this.distance.GetComponent<Text>().text = "��ǥ �������� " + lengthValue + "m";

        // length�� �Ҽ��� ��°�ڸ������� ����ϱ� ������ length == 0 ���� �ϰԵǸ�
        // �ؽ�Ʈ�� 0.00 �̾ text�� ������� �ʴ� ��Ȳ�� �߻��Ѵ�. 
        // �̸� �ذ��ϱ� ���Ͽ� ��µǴ� text�� ���ڿ� ������ �����Ͽ� ����Ͽ���.
        else if (lengthValue.Equals("0.00")) 
            this.distance.GetComponent<Text>().text = "Game Clear";

        // �÷��� ����
        else if (length < 0)
            this.distance.GetComponent<Text>().text = "Game Over";
    }
}
