using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyController : MonoBehaviour
{
    string EnemyName = "슬라임";
    int HP = 50;
    int damage = 15;
    
    void TakeDamage(int damge)
    {
        HP = HP - damge;
    }
    void Start()
    {
        Debug.Log(EnemyName);
    }
    void Update()
    {
        if (HP <= 0)
        {
            Debug.Log("슬라임이 쓰러졌다!");
        };
        
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            TakeDamage(damage);
            Debug.Log(HP);
        };
    }
}