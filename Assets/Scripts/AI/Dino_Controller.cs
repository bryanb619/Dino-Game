using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Dino_Controller : MonoBehaviour
{
	//public Transform target;

	public float speed = 3f;

	private Rigidbody rb;



	// Use this for initialization
	void Start()
	{	


		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.right * speed;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "DESTROYER")
		{
			Destroy(gameObject);
		}

	}
}
