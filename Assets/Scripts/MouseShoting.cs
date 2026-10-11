using UnityEngine;

public class MouseShoting : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Camera _camera;

    private SpriteRenderer sr;
    private Farmer player;
    private AudioSource audioSource;

    private Vector3 aimDirection;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        player = GetComponentInParent<Farmer>();
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        RotateToMouse();
    }

    private void RotateToMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 mouseWorldPos = _camera.ScreenToWorldPoint(mousePos);
        mouseWorldPos.z = transform.position.z;

        aimDirection = mouseWorldPos - transform.position;

        transform.rotation = Quaternion.FromToRotation(Vector3.right, aimDirection);
        sr.flipY = aimDirection.x < 0;

    }

    private void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        projectile.transform.rotation = Quaternion.FromToRotation(Vector3.up, aimDirection);
    }

}
