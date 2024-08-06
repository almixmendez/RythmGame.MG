using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Destruye el efecto de la nota luego de un segundo.
public class EffectObject : MonoBehaviour
{
    [SerializeField] private float lifetime = 1f;

    void Update()
    {
        Destroy(gameObject, lifetime);
    }
}
