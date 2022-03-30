using UnityEngine;

public class EnemyAtGoal : MonoBehaviour
{
    void Start()
    {
        gameObject.tag = "Goal";   
    }

    void OnTriggerEnter(Collider other)
    {
		if (other.tag == "dino")
		{
			Debug.Log("dino reached goal");

		}
	}
}
