using UnityEngine;

public class DinoSpawner : MonoBehaviour
{
    [SerializeField]    private GameObject DinoPrefab;
    
                        public float spawnRate;
                        private float _nextSpawn;
    

    private void Update()
    {
        SpawnDino();
    }

    private void SpawnDino()
    {
        if (!(Time.time > _nextSpawn)) return;
        
        Instantiate(DinoPrefab, transform.position, transform.rotation);
       
        _nextSpawn = Time.time + spawnRate;
    }
}
