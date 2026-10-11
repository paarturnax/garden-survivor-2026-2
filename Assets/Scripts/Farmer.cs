using UnityEngine;

public class Farmer : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private int bullets;
    [SerializeField] private Hp healthUI;
    [SerializeField] private AmmoUI ammoUI;
    [SerializeField] private PanelMenu panel;

    public int Bullets => bullets;

    private void Start()
    {
        healthUI.UpdateHp(hp);
        ammoUI.UpdateAmmo(bullets);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Zombie zombie = collision.gameObject.GetComponent<Zombie>();
        if (zombie != null)
        {
            TakeDamage(zombie.Damage);
            zombie.Die();
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

    public void ChangeBullets(int amount)
    {
        bullets += amount;
        ammoUI.UpdateAmmo(bullets);
    }

    private void Die()
    {
        panel.Show();
    }
}
