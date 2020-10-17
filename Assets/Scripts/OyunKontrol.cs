using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{
    public  Text zamanText, BalonText,durumText,HealtText;
    public  GameObject patlama,btn;
    public  float zamansayaci = 60;
    int patlayanBalon = 0;
   
    void Start()
    {
        BalonText.text = "" + patlayanBalon;
    }
    void Update()
    {
        if (zamansayaci > 0) { 
        zamansayaci -= Time.deltaTime;
        zamanText.text = "" + (int)zamansayaci;
        }else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i = 0; i< go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go [i]);
            }
        }
        if (zamanText.text == "0")
        {
            durumText.text = "Oyun Tamamlandı " +
                             "Patlayan Balon Sayısı" + "  "  +
                                    patlayanBalon;
            btn.SetActive(true);

        }

    }
    public void Balonekle()
    {
        patlayanBalon += 1;
        BalonText.text = " " + patlayanBalon;
    }

   
}
