using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;

    OyunKontrol oyunkontrolscrpti;


    private void Start()
    {
        oyunkontrolscrpti = GameObject.Find("_Script").GetComponent<OyunKontrol>();

    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;


        Destroy(this.gameObject);
        Destroy(go, 0.233f);
        oyunkontrolscrpti.Balonekle();

    } 
}


