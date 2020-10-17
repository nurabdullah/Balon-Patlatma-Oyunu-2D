using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonArtırma : MonoBehaviour
{
    public GameObject[] balon ;
    float balonolusturmasuresi = 1f;
    float zamansayaci = 0f;
    OyunKontrol okscripti; 
    void Start()
    {
        okscripti = this.gameObject.GetComponent<OyunKontrol>();
    }

  
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        int katSayaci = (int)(okscripti.zamansayaci / 10) - 6;
        katSayaci *= -1;
        if (zamansayaci < 0 && okscripti.zamansayaci>0)
        {
            GameObject go = Instantiate(balon[Random.Range(0,4)], new Vector3(Random.Range(-2.24f, 2.22f), -5.87f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(30f*katSayaci,80f*katSayaci) , 0));
            zamansayaci = balonolusturmasuresi;

           

        }
    }

}
