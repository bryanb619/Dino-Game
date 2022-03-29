using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 20f;
	public int damage = 100;
	public Rigidbody rb;
	public GameObject impactEffect;


	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.forward * speed;
	}

	void OnTriggerEnter(Collider hitInfo)
	{

		// change enemy for object and add dino for fun animation and sound effect!
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
			Debug.Log("HIT");
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

		

		Destroy(gameObject);
	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}


}
