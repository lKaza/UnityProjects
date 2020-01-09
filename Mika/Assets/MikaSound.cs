using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikaSound : MonoBehaviour
{

    public AudioSource audio;
    private AudioClip audioClip;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.tag == "Mika")
            {
                audio = GetComponent<AudioSource>();
                audio.Play();
                Debug.Log("HITMika");
            }
            else
            {
                Debug.Log("Did not hit anything");
            }
        }
    }
}
