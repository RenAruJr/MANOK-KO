using UnityEngine;
using UnityEngine.UI;

public class HeartUI : MonoBehaviour
{
    public Health playerHealth;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].sprite = i < playerHealth.currentHearts ? fullHeart : emptyHeart;
        }
    }
}