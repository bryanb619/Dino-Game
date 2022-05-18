using UnityEngine;

public class SheepShooter : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private GameObject SheepPrefab;

    [SerializeField]
    private Transform ClawFirePoint;



    // Start is called before the first frame update
    void Start()
    {
        // rb.velocity = Vector3.zero;

        Instantiate(SheepPrefab, ClawFirePoint.position, ClawFirePoint.rotation);
    }

    
    // Get dino Info 
    void OnTriggerEnter(Collider hitInfo)
    {
        PoinSystem point = hitInfo.GetComponent<PoinSystem>();
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if (point != null && enemy != null)
        {
            // add point
            PoinSystem.Instance.AddPoint();

            // attach to sheep // attach sheep to dino Y axis POSITION
            enemy.Attach();

            
            
        }
        
    }
}
