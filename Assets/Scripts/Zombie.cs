using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private int maxHp;
    [SerializeField] private EnemyHp healthUI;

    private int hp;
    private Animator animator;
    private ParticleSystem bloodEffect;

    public int Damage => damage;

    private void Start()
    {
        hp = maxHp;
        healthUI.UpdateHp(hp, maxHp);
        animator = GetComponent<Animator>();
        bloodEffect = GetComponentInChildren<ParticleSystem>();
    }

    public void TakeDamage(int damage)
    {
        if(damage > hp)
        {
            damage = hp;
        }
        hp -= damage;
        healthUI.UpdateHp(hp, maxHp);
        animator.SetTrigger("isHit");
        bloodEffect.Play();

        if (hp == 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
