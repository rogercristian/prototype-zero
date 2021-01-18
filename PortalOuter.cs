using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOuter : MonoBehaviour
{
    public GameObject inBuilding;
    public GameObject inBuildingLightGlobal;

    public GameObject[] outBuilding;
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {           
           inBuilding.SetActive(false);
           inBuildingLightGlobal.SetActive(false);
                for (int i = 0; i < outBuilding.Length; i++)
                {
                    outBuilding[i].SetActive(true);
                }           
            
        }

    }
}
