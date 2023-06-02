using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class car : MonoBehaviour
{
    
    public float hareketHizi = 5f;


    void Update()
    {
        float yatayHareket = Input.GetAxis("Horizontal");
        float dikeyHareket = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatayHareket, 0f, dikeyHareket) * hareketHizi * Time.deltaTime;

        transform.Translate(hareket);
    }
}
