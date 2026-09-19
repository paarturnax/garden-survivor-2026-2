using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform player;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float movement = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,
            player.position, movement);
        
        if (player.position.x > transform.position.x)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }
    }

    public void SetTarget(Transform player)
    {
        this.player = player;
    }
}
