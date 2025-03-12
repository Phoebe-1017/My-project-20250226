using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    [SerializeField]
    private GameObject 物件;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(message: "OnTriggerEnter2D");
        物件.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
     Debug.Log(message:"完美落地！10分");
    //gameObject.SetActive(false);
    // col.gameObject.SetActive(false);

     //GameObject 物件 = GameObject.Find("物件");
     物件.SetActive(true);
    }
}


