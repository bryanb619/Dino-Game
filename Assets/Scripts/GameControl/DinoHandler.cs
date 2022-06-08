using UnityEngine;

public class DinoHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DESTROYER")
        {
            Destroy(gameObject);
        }

    }
}
