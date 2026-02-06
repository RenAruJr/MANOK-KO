using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject swordHitbox;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            swordHitbox.SetActive(true);
            Invoke(nameof(StopAttack), 0.2f);
        }
    }

    void StopAttack()
    {
        swordHitbox.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Enemy"))
        other.GetComponent<Enemy>().TakeDamage(1);
}
}