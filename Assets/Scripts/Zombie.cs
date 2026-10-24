using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private int maxHp;
    [SerializeField] private EnemyHP healthUI;

    private Animator animator;

    private int hp;
    public int Damage => damage;

    private void Start()
    {
        hp = maxHp;
        healthUI.UpdateHP(hp, maxHp);
    }

    public void TakeDamage(int dmg)
    {
        if (dmg > hp)
        {
            dmg = hp;
        }
        hp -= dmg;
        healthUI.UpdateHP(hp, maxHp);
        animator.SetTrigger("isHit");
        if (hp == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
