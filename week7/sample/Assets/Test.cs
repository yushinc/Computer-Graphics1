using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "데미지를 입혔다.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다.");
    }

}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() // 시작할 때 한번만 호출
    {
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);
    }

    // Update is called once per frame
    void Update() // 프레임이 업데이트될 때마다 호출
    {
        
    }
}
