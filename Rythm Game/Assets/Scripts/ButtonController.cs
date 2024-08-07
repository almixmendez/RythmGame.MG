using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cambia la imagen del botón cuando se presiona la tecla asignada.
public class ButtonController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite defaultImage;
    [SerializeField] private Sprite pressedImage;

    [SerializeField] private KeyCode keyToPress;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            spriteRenderer.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            spriteRenderer.sprite = defaultImage;
        }
    }
}
