using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(AudioSource))]
public class Shooter : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private PoinSystem points;
    private BoxCollider _collider;
    private SpriteRenderer _sprite;

    private AudioSource _dinoHit; 

    // Start is called before the first frame update
    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
        
        _dinoHit = GetComponent<AudioSource>();
        
        _dinoHit.playOnAwake = false;
        _dinoHit.loop = false;
        _dinoHit.volume = 0.4f;
        
        _collider = GetComponent<BoxCollider>();
    }

    // Get dino Info 
    void OnTriggerEnter(Collider hitInfo)
    {
        Enemy enemy         = hitInfo.GetComponent<Enemy>();
        HatNoZone NOZONE    = hitInfo.GetComponent<HatNoZone>();

        if (NOZONE != null) {
            DestroyHat();
            NOZONE.AddLog();
        }

        else if ( enemy != null) {
            
#if UNITY_EDITOR
            Debug.Log("Dino HIT");
#endif
            // play sound
            _dinoHit.Play();
            
            // disable collider
            _collider.enabled = false;
            _sprite.enabled = false;
            
            // add point
            PoinSystem.Instance.AddPoint();
            
            // change sprite
            enemy.DinoHit();

            // Destroy
            DestroyHat();
        }
    }
    
    void OnBecameInvisible()
    {
        DestroyHat();
    }
    
    /// <summary>
    /// calls destroy coroutine
    /// </summary>
    private void DestroyHat()
    {
        // Call DestroyTime
        StartCoroutine(DestroyTime());

    }

    /// <summary>
    /// Destroys hat after set seconds
    /// </summary>
    /// <returns></returns>
    private IEnumerator DestroyTime()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);

    }


}
