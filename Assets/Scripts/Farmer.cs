using UnityEngine;

public class Farmer : MonoBehaviour
{
    [SerializeField] private int hp;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Zombie zombie = collision.gameObject.GetComponent<Zombie>();
        if (zombie != null)
        {
            TakeDamage(zombie.Damage);
            Destroy(collision.gameObject);
        }
    }

    private void TakeDamage(int damage)
    {
        if(damage > hp)
        {
            damage = hp;
        }
        hp -= damage;
    }
}
