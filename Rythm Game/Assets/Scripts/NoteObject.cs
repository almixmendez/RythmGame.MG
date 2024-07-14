using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public bool obtained = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                GameManager.instance.NoteHit();
                obtained = true;
                gameObject.SetActive(false);
                //GameManager.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Destroyer"))
        {
            GameManager.instance.NoteMissed();
            Destroy(other.gameObject);
        }
        if (other.tag == "Activator") 
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
           canBePressed = false;
           if (!obtained)
            {
                GameManager.instance.NoteMissed();
            }
        }
    }
}
