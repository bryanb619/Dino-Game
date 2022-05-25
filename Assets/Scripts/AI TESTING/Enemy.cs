using UnityEngine;

public class Enemy : MonoBehaviour
{

    //public GameObject deathEffect;
    void Start()
    {
        
    }
    public void Attach()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        // Destroy(gameObject);
        Debug.Log("Dino was shot");

        // HOW TO ATTACH SHEEP

        //prefabInstantiation = Instantiate(objectPrefab, position, rotation) as GameObject;

        //prefabInstantiation.transform.parent = DinoHead.transform;





    }
}
