using UnityEngine;

public class ClawInput : MonoBehaviour
{
    // Player default anim
    //public Animator _playerAnimator;


    // Shoot config
    //[Header("Shoot Settings")]
    //public Transform firePoint;
    //public GameObject bulletPrefab;

    private float shootSpeed = 10f;
    private float timeToShoot = 1.3f;
    private float orginalTime;

    private float fireRate = 0.8f;
    private float nextFire = 0f;



    private bool GoLeft, GoRight;



    void Start()
    {
        orginalTime = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        // Detect Player Input
        PlayerInput();
    }

   private void PlayerInput()
   {
        // LEFT INPUT
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GoLeft = true;
        }

        // RELEASE LEFT
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GoLeft = false;
        }

        // RIGHT INPUT
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GoRight = true;
        }


        // RELEASE RIGHT
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GoRight = false;
        }

        // APPLY PLAYER INPUT
        GetInput();
    }

    private void GetInput()
    {
        // Go left
        if(GoLeft)
        {
            gameObject.transform.Translate(-0.03f ,0, 0);
        }

        // Go Right
        if(GoRight)
        {
            gameObject.transform.Translate(0.03f, 0, 0);
        }
    }


    /*
    private void DetectPlayerInput()
    {
        // Fire
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Shoot();
            }

                
        }

        
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    */
 
}
