using UnityEngine;

//[RequireComponent(typeof(BoxCollider))]
public class ClawInput : MonoBehaviour
{
    #region Variables
    // Player default anim
    //public Animator _playerAnimator;

    // Shoot config
    //[Header("Shoot Settings")]
    //public Transform firePoint;
    //public GameObject bulletPrefab;

    private float TimeToShoot = 1.3f;
    private float OrginalTime;

    private float fireRate = 0.8f;
    private float nextFire = 0f;

    private Shooter Shooter;
    private bool GoLeft, GoRight;
    [SerializeField]
    private GameObject HatPrefab;
    [SerializeField]
    private Transform ClawFirePoint;


    private float MinDistR = 8f, MinDistL = 6f;
    private float dist;
    private bool CanMoveL, CanMoveR;
    public bool canMoveL => CanMoveL;

    //public BoxCollider box;

    //[SerializeField] private Transform CentralPos;

    #endregion

    void Start()
    {
        OrginalTime = TimeToShoot;

        CanMoveL = true;
        CanMoveR = true;

    }

    // Update is called once per frame
    void Update()
    {
        //distL = Vector3.Distance(MaxLimitRight.position, transform.position);
        //dist = Vector3.Distance(CentralPos.position, transform.position);


        // Detect Player Input


        //print("DIST TO LEFT: "+ distL);

        //print("DIST OF CENTER: "+ dist);

        //CheckLeft();

        //OnTriggerEnter(box);
        //PlayerInput();
        FireInput();

        ChangeBool();
        ChangeBool2();

        PlayerInput();



    }

    public void ChangeBool()
    {
        CanMoveL = false;
    }

    public void ChangeBool2()
    {
        CanMoveL = true;
    }



    private void PlayerInput()
   {

        // RELEASE LEFT
        if (Input.GetKeyUp(KeyCode.LeftArrow) || CanMoveL == false)
        {
            GoLeft = false;
        }
        // RELEASE RIGHT
        if (Input.GetKeyUp(KeyCode.RightArrow) || CanMoveR == false)
        {
            GoRight = false;
        }

        // LEFT INPUT
        if (Input.GetKeyDown(KeyCode.LeftArrow ) && CanMoveL)
        {
            GoLeft = true;
            //print("LEFT INPUT CLICKED");
        }        

        // APPLY PLAYER INPUT
        //GetInput();
        // RIGHT INPUT

        if (Input.GetKeyDown(KeyCode.RightArrow) && CanMoveR)
        {
            GoRight = true;

            //print("RIGHT INPUT CLICKED");
        }

        GetInput();

   }

    private void GetInput()
    {
        // Go left
        if(GoLeft)
        {
            gameObject.transform.Translate(-0.01f ,0, 0);
        }

        // Go Right
        if(GoRight)
        {
            gameObject.transform.Translate(0.01f, 0, 0);
        }
    }

    private void FireInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > nextFire)
            {

                nextFire = Time.time + fireRate;

                Instantiate(HatPrefab, ClawFirePoint.position, ClawFirePoint.rotation);

            }
        }
    }
}
