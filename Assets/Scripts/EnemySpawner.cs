using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private ZombieMovement prefab;
    [SerializeField] private Transform player;
    [SerializeField] private float spawnDelay;
    [SerializeField] private float leftRightDistance;
    [SerializeField] private float upDownDistance;
    void Start()
    {
        //InvokeRepeating()
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        ZombieMovement enemy = Instantiate(prefab);
    }

    private void SetupEnemy(ZombieMovement enemy)
    {
        Vector3 position = getRandomPosition();
    }

    private Vector3 getRandomPosition()
    {
        float x = Random.Range(-leftRightDistance, leftRightDistance);
        float y = Random.Range(-upDownDistance, upDownDistance);
        return new Vector3(x, y, 0);
    }
}
