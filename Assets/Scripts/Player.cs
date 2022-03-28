using UnityEngine;

public class Player : MonoBehaviour
{
    // Player default anim
    public Animator _playerAnimator;


    // Shoot config
    public Transform firePoint;
    public GameObject bulletPrefab;


    // Player camera
    [Header("Player Camera")]
    [SerializeField] private Camera playerCamera;

    // Look Speed
    [SerializeField] private float lookSpeed = 2.0f;
    // Camera X limitation
    [SerializeField] private float lookXLimit = 45.0f;

    
    // player rotation
    float rotationX = 0;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectPlayerInput();
        //CameraRotation();

    }

    private void FixedUpdate()
    {
        LockCursor();

        
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


    private void LockCursor()
    {
        //Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;

    }

    private void CrossHair()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = mouseCursorPos;
    }

    private void CameraRotation()
    {

        rotationX += -Input.GetAxis("Mouse_Y") * lookSpeed;
        rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse_X") * lookSpeed, 0);

    }
}
