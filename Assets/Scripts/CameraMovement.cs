using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float leftRightDistance;
    [SerializeField] private float upDownDistance;

    private void Move()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10f);
    }

    private void Restrict()
    {
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -leftRightDistance, leftRightDistance);
        position.y = Mathf.Clamp(position.y, -upDownDistance, upDownDistance);
        transform.position = position;
    }
    void Update()
    {
        Move();
        Restrict();
    }
}
