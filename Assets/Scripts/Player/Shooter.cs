using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private PoinSystem points;

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
        HatNoZone NOZONE = hitInfo.GetComponent<HatNoZone>();


        if (NOZONE != null)
        {
            Destroy(gameObject);
            NOZONE.AddLog();
        }

        else if ( enemy != null)
        {

            Debug.Log("Dino HIT");
            // add point
            PoinSystem.Instance.AddPoint();
           
            
            // change sprite
            enemy.DinoHit();

            Destroy(gameObject);


        }
        
        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
