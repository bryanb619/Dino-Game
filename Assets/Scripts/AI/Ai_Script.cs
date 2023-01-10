using UnityEngine;
using UnityEngine.AI;

public class Ai_Script : MonoBehaviour
{
    // criar variavel para usar esse agent
    private NavMeshAgent nav;

    // variavel editavel no editor para definir goal target
    [SerializeField]
    private Transform goalTarget;

    // Start is called before the first frame update
    void Start()
    {
        // usar variavel para buscar ( get component logo no inicio do run)
        nav = GetComponent<NavMeshAgent>();

        // find position
        nav.SetDestination(goalTarget.position);

    }


}
