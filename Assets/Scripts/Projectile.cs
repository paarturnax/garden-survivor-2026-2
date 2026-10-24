using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float lifetime = 1f;
    [SerializeField] private int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Zombie zombie = collision.gameObject.GetComponent<Zombie>();
        if (zombie != null)
        {
            zombie.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
