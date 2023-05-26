using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_Game : MonoBehaviour
{
    // Program zgaduje liczbe ktora wymyslilismy sobie z konkretnego przedzialu liczbowego.
    //Przedzial od 1 do 1000 i program pyta czy wymyœlona liczba jest wikesza od mniejsza.
    //Gracz odpowiada mniejsza, wieksza lub rowna.
    //ALGORYTM -> wyszukiwanie binarnie ->


    int min = 1;
    int max = 1000;
    int shoot = 500;

    void Start()
    {
        Debug.Log("Witam w grze - pomyœl o liczbie od "+min+ "do" + max);
        max = 1001;
        Debug.Log("Czy twoja liczba jest mniejsza/ rowna/ wieksza od 500?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            NextShoot();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            NextShoot();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgadl liczbe");
        }
    }

    void NextShoot()
    {
        shoot = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest wieksza/rowna/ mniejsza od " + shoot + " ?");
    }

}
