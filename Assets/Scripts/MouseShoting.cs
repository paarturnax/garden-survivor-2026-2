using UnityEngine;

public class MouseShoting : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform muzzle;

    private SpriteRenderer sr;
    private SpriteRenderer playerSr;
    private Farmer player;
    private AudioSource audioSource;

    private Vector3 aimDirection;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        playerSr = transform.parent.GetComponent<SpriteRenderer>();
        player = GetComponentInParent<Farmer>();
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        RotateToMouse();

        if (player.Bullets > 0 && Input.GetMouseButtonDown(0))
        {
            Shoot();
            audioSource.Play();
            player.ChangeBullets(-1);
        }
    }

    private void RotateToMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 mouseWorldPos = _camera.ScreenToWorldPoint(mousePos);
        mouseWorldPos.z = transform.position.z;

        aimDirection = mouseWorldPos - transform.position;

        transform.rotation = Quaternion.FromToRotation(Vector3.right, aimDirection);
        sr.flipY = aimDirection.x < 0;
        playerSr.flipX = aimDirection.x < 0;

    }

    private void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, muzzle.position, Quaternion.identity);
        projectile.transform.rotation = Quaternion.FromToRotation(Vector3.up, aimDirection);
    }

}
