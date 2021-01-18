using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Portal : MonoBehaviour
{ 
    [SerializeField] private float timeToEnable;

    public GameObject inBuilding;
    public GameObject inBuildingLightGlobal;
    public GameObject[] outBuilding;      
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") )
        {
          
          inBuilding.SetActive(true);
          inBuildingLightGlobal.SetActive(true);
                for (int i = 0; i < outBuilding.Length; i++)
                {
                    outBuilding[i].SetActive(false);
                }         
        }       
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(timeToEnable);        

    }
}
