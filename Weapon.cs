using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
   
    public  Transform shootPoint;

   
    public  LineRenderer lineRenderer;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(shootPoint.position, shootPoint.right);

        if(hitInfo)
        {
            lineRenderer.SetPosition(0, shootPoint.position);
            lineRenderer.SetPosition(3, hitInfo.point);
        }
        else
        {
            lineRenderer.SetPosition(0, shootPoint.position);
            lineRenderer.SetPosition(3, shootPoint.position + shootPoint.right * 100);

        }
    }
}
