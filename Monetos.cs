using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Monetos : MonoBehaviour
{
    private float Moneta = 0;


    public TextMeshProUGUI textMoneta;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Moneta")
        {
            Moneta++;
            textMoneta.text = Moneta.ToString();
            Destroy(collision.gameObject);
        }
    }
      
}
