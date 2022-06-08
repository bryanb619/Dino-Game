using UnityEngine;

public class DinoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject DinoPrefab;

    [SerializeField] private float TimeToSpawn = 1.3f;
    [SerializeField] private float SpawnRate = 2f;
    private float nextSpawn = 0f;

    private float OrginalTime;

    private void Start()
    {
        OrginalTime = TimeToSpawn;
        
    }

    private void Update()
    {
        SpawnDino();
    }

    private void SpawnDino()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            Instantiate(DinoPrefab, transform.position, transform.rotation);

        }
    }
}
