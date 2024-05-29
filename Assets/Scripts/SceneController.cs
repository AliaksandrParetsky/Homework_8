using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;

    [SerializeField] List<Paralax> paralax = new List<Paralax>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterController.FlipX();
            ChangeParalaxDirection();
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
