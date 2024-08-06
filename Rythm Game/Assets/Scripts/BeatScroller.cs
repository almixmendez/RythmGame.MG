using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Rendering;

// Baja las notas al tempo de la música (BPM).
public class BeatScroller : MonoBehaviour
{
    [SerializeField] private float beatTempo;
    [SerializeField] private GameObject pressAnyKeyPanel;
    public bool hasStarted;

    void Start()
    {
        pressAnyKeyPanel.SetActive(true);
        beatTempo = beatTempo / 60f;
    }

    void Update()
    {
        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                pressAnyKeyPanel.SetActive(false);
                hasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
