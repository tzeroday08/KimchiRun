using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    string PlayerName = "Player";
    int HP = 100;
    int maxHP = 100;
    int damage = 25;
    double PlayerMovespeed = 2.5;
    bool isJumping = true;
    void Start()
    {

    }
    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            Debug.Log("[A] 공격");
            if (isJumping)
            {
                isJumping = false;
                Debug.Log("착지");
            }
        };
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            Debug.Log("[S] 방어");
            Debug.Log("체력상태 : " + HPdangerous());
        };
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            Debug.Log("[Z] 대미지");
            TakeDamage(damage);
            Debug.Log(damage + "피해");

            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Debug.Log("[Space] 점프");

                if (isJumping)
                {
                    Debug.Log("공중에서는 점프할 수 없습니다.");
                }
                else
                {
                    isJumping = true;
                    Debug.Log("점프");
                };
            };
        }
        
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isJumping)
        {
            Debug.Log("공중에서는 점프할 수 없습니다.");
        }
        else if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            isJumping = true;
            Debug.Log("왼쪽으로 점프");
        }
        else if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            isJumping = true;
            Debug.Log("오른쪽으로 점프");
        }
        else if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            isJumping = true;
            Debug.Log("위로 점프");
        }
    }
    void TakeDamage(int damage)
    {
        HP = HP - damage;
        Debug.Log("데미지 : " + damage + "남은 체력 : " + HP);
        Debug.Log("게임 시작 [space] 점프, [A] 굥격, [S] 방어, [Z] 대미지");
    }
    private string HPdangerous()
    {
        if (HP / maxHP >= 2 / 3)
        {
            return "건강함";
        }
        else if (HP / maxHP >= 1 / 3)
        {
            return "위험";
        }
        else
        {
            return "반사";
        }
    }
}
