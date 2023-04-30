using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetChange : MonoBehaviour
{
    public GameObject[] planets;
    public Animator BlackOut;
    public bool start;



    private void Update()
    {
        if (start)
        {
            start = false;
            ChangePlanet(planets[2]);
        }
    }
    public void ChangePlanet(GameObject planet)
    {
        
        StartCoroutine(Wait(planet));
        
    }

    IEnumerator Wait(GameObject planet)
    {
        yield return new WaitForSeconds(0.5f);
        BlackOut.SetTrigger("Blackout");
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < planets.Length; i++)
        {
            if(planets[i].activeSelf == true)
            {
                planets[i].SetActive(false);
            }
        }
        planet.SetActive(true);
    }
}
