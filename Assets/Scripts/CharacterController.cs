using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isFlip;

    public SpriteRenderer SpriteRenderer
    {
        get
        {
            if(spriteRenderer == null)
            {
                spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.flipX = false;
            }

            return spriteRenderer;
        }
    }

    private void Start()
    {
        isFlip = false;
    }

    public void FlipX()
    {
        if (isFlip)
        {
            SpriteRenderer.flipX = false;
            isFlip = false;
        }
        else
        {
            SpriteRenderer.flipX = true;
            isFlip = true;
        }
    }
}
