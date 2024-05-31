using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] List<Paralax> paralax = new List<Paralax>();

    private void OnEnable()
    {
        CharacterController.onTouched += ChangeParalaxDirection;
    }

    private void OnDisable()
    {
        CharacterController.onTouched -= ChangeParalaxDirection;
    }

    private void ChangeParalaxDirection()
    {
        foreach (var item in paralax)
        {
            item.ChangeDirection();
        }
    }
}
