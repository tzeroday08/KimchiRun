using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int HP = 100;
    void Start()
    {
        Debug.Log("Game Start");
        Debug.Log(HP);

        if (HP < 50)
        {
            Debug.LogWarning("HP부족!");
        }
        if (HP < 25)
        {
            Debug.LogWarning("위험!");
        }
    }

    void Update()
    {

    }
}
