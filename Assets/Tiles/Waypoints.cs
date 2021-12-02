using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] bool isPlaceble ;//to make this a property .. we use it in another scripts so make it look like this 
    public bool IsPlaceble{get{return isPlaceble;}}
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
