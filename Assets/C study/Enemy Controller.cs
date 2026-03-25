using UnityEngine;

public class EnemyController : MonoBehaviour
{
    string Enemy_Name = ("고블린");
     int Enemy_HP = 80;
    double Enemy_Movespeed = 2.5;      
    bool Enemy_Attack = true;

    void Start()
    {
        Debug.Log(Enemy_Name);
        Debug.Log(Enemy_Movespeed);
        Debug.Log(Enemy_HP);
        Debug.Log(Enemy_Attack);
    }
        
    
    
}

