using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform DinoHead, SheepPrefab;

    //public GameObject deathEffect;

    public void Attach()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        // Destroy(gameObject);
        Debug.Log("Dino was shot");

        // HOW TO ATTACH SHEEP
        DinoHead.transform.parent = SheepPrefab.transform;


        
    }
}
