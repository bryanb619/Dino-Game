using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite newSprite;
    [SerializeField] private BoxCollider boxCollider;

    //[SerializeField] private GameObject currentObject;


    public void DinoHit()
    {
        ApplyHit();
    }

    private void ApplyHit()
    {
        spriteRenderer.sprite = newSprite;
        Destroy(boxCollider);
    }
}
