using UnityEngine;

public class Farmer : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int bullets;
    [SerializeField] private Hp healthUI;
    [SerializeField] private AmmoUI ammoUI;
    [SerializeField] private PanelMenu panel;

    public int Bullets => bullets;

    public void ChangeBullets(int amount)
    {
        bullets += amount;
        ammoUI.UpdateAmmo(bullets);
    }

    private void Start()
    {
        ammoUI.UpdateAmmo(bullets);
        healthUI.UpdateHp(hp);
    }

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
        healthUI.UpdateHp(hp);

        if (hp == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        panel.Show();
    }
}
