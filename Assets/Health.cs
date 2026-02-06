using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHearts = 3;
    public int currentHearts;

    void Start()
    {
        currentHearts = maxHearts;
    }

    public void TakeDamage(int damage)
    {
        currentHearts -= damage;

        if (currentHearts <= 0)
        {
            Debug.Log("Player died");
        }
    }
}