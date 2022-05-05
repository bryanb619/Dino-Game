using UnityEngine;

public class Player : MonoBehaviour
{
    // Player default anim
    //public Animator _playerAnimator;


    // Shoot config
    [Header("Shoot Settings")]
    public Transform firePoint;
    public GameObject bulletPrefab;

    private float shootSpeed = 10f;
    private float timeToShoot = 1.3f;
    private float orginalTime;

    private float fireRate = 0.8f;
    private float nextFire = 0f;

    void Start()
    {
        orginalTime = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        DetectPlayerInput();
       

    }

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
 
}
