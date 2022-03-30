using UnityEngine;

public class Player : MonoBehaviour
{
    // Player default anim
    //public Animator _playerAnimator;


    // Shoot config
    public Transform firePoint;
    public GameObject bulletPrefab;

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
            Shoot();
        }

        
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
 
}
