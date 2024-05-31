using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isFlip;
    public bool IsFlip 
    {
        get { return isFlip; }
        set { isFlip = value; }
    }

    public static Action onTouched;

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
        IsFlip = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FlipX();

            onTouched?.Invoke();
        }
    }

    public void FlipX()
    {
        if (IsFlip)
        {
            SpriteRenderer.flipX = false;
            IsFlip = false;
        }
        else
        {
            SpriteRenderer.flipX = true;
            IsFlip = true;
        }
    }
}
