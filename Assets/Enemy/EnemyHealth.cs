using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoint = 5;
    [SerializeField] int currentHitpoints = 0;
    void Start()
    {
       currentHitpoints= maxHitPoint;
    }
    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }
    void ProcessHit()
    {
        currentHitpoints --;
        if(currentHitpoints <= 0){
            Destroy(gameObject);
        }
    }
}
