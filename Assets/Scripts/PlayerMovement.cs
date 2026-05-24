using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Vector2 GetMovementFromInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        print($"{horizontal} {vertical}");
        Vector2 movement = new Vector2(horizontal, vertical);
        return movement * speed * Time.deltaTime;
    }

    private void Move()
    {
        Vector2 movement = GetMovementFromInput();
        transform.Translate(movement);
    }
    
    void Update()
    {
        Move();
    }
}
