using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Paralax : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private float singleTextureWidth;

    private void Start()
    {
        SetupTexture();
    }

    private void Update()
    {
        Scroll();
        CheckReset();
    }

    private void SetupTexture()
    {
        if (GetComponent<SpriteRenderer>())
        {
            Sprite sprite = GetComponent<SpriteRenderer>().sprite;

            singleTextureWidth = sprite.texture.width / sprite.pixelsPerUnit;
        }
    }

    private void Scroll()
    {
        float delta = -moveSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(delta, 0, 0);
    }

    private void CheckReset()
    {
        if((Math.Abs(transform.position.x) - singleTextureWidth) > 0)
        {
            transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);
        }
    }

    public void ChangeDirection()
    {
        moveSpeed = -moveSpeed;
    }
}
