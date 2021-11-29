using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] bool isPlaceble ;
    [SerializeField] GameObject towerPrefeb ;
    void OnMouseDown()
    {
        if(isPlaceble)
        {
            Instantiate(towerPrefeb,transform.position,Quaternion.identity);
            isPlaceble = false;
        }
    }   
}
