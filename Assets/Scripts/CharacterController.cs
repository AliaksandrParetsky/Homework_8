using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CharacterController : MonoBehaviour
{
    [SerializeField] List<Paralax> paralax = new List<Paralax>();
    private SpriteRenderer spriteRenderer;
    private bool isFlip;

    private void Start()
    {
        if (GetComponent<SpriteRenderer>())
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        
        isFlip = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isFlip)
            {
                spriteRenderer.flipX = false;
                isFlip = false;

                ChangeParalaxDirection();
            }
            else
            {
                spriteRenderer.flipX = true;
                isFlip = true;

                ChangeParalaxDirection();
            }
        }
    }

    private void ChangeParalaxDirection()
    {
        foreach (var item in paralax)
        {
            item.ChangeDirection();
        }
    }
}
