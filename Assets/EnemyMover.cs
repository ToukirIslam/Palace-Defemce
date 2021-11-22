using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoints> path = new List<Waypoints>();
    [SerializeField] float emSpeed = 2;
    void Start()
    {
        StartCoroutine(FollowPath());
        
    }
    IEnumerator FollowPath()
    {
        foreach(Waypoints ways in path)
        {
            Vector3 starPos = transform.position;
            Vector3 targetPos = ways.transform.position;
            float travalPercent = 0f;
            while(travalPercent < 1f)
            {
                travalPercent += emSpeed* Time.deltaTime;
                transform.LookAt(targetPos);
                 transform.position = Vector3.Lerp(starPos,targetPos,travalPercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
