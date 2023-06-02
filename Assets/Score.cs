using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public TMP_Text altinText;
    public int TopAltin = 0;
    public void Update()
    {
        altinText.text = "Toplanan Altin:" + " " + TopAltin.ToString();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            TopAltin++;
            Destroy(other.gameObject);
        }
        if (other.tag == "Engel")
        {
            SceneManager.LoadScene(0);
        }
    }
    
}
