using UnityEngine;

public class SheepShooter : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    // Start is called before the first frame update
    public void Start()
    {
        // rb.velocity = Vector3.zero;

       
    }

    
    // Get dino Info 
    void OnTriggerEnter(Collider hitInfo)
    {
        //PoinSystem point = hitInfo.GetComponent<PoinSystem>();
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if ( enemy != null)
        {

            Debug.Log("Dino HIT");
            // add point
            PoinSystem.Instance.AddPoint();

            // attach to sheep // attach sheep to dino Y axis POSITION
            //enemy.Attach();

                      
        }
        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
