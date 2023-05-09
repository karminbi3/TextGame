using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_Game : MonoBehaviour
{
    // Program zgaduje liczbe ktora wymyslilismy sobie z konkretnego przedzialu liczbowego.
    //Przedzial od 1 do 1000 i program pyta czy wymyœlona liczba jest wikesza od mniejsza.
    //Gracz odpowiada mniejsza, wieksza lub rowna.
    //ALGORYTM -> wyszukiwanie binarnie ->

  
    void Start()
    {
        Debug.Log("Witam w grze - pomyœl o liczbie od 1 do 1000");
        Debug.Log("Czy twoja liczba jest mniejsza/ rowna/ wieksza od 500?");
        //print string
        //górna strza³ka by odpowiedziec ¿e wiêksza
        if (Input.GetKeyDown(KeyCode.UpArrow)) ;
        {
            Debug.Log("hje");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
