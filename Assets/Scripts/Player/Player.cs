using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody ClawRigidBody;
   
    [Range(1f, 10f)]
    [SerializeField] private float speed = 3.5f;

    private float hozMove = 0f;


    private float TimeToShoot = 1.3f;
    private float OrginalTime;

    private float fireRate = 0.8f;
    private float nextFire = 0f;

    private Shooter Shooter;

    [SerializeField]
    private GameObject HatPrefab;
    [SerializeField]
    private Transform ClawFirePoint;





    // Start is called before the first frame update
    private void Start()
    {
        /*
        // print 
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        FireInput();


    }
    private void FixedUpdate()
    {
        
        MovePlayer();
    }

    private void PlayerInput()
    {
        hozMove = Input.GetAxis("Horizontal");
    }

    private void MovePlayer()
    {
        Vector3 direction = new Vector3(hozMove, 0, 0).normalized;
        transform.Translate(direction * speed * Time.deltaTime);    
    }

    private void FireInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > nextFire)
            {

                nextFire = Time.time + fireRate;

                Instantiate(HatPrefab, ClawFirePoint.position, ClawFirePoint.rotation);

            }
        }
    }


    public void Obliterate()
    {
        Destroy(this.gameObject);
    }


}
