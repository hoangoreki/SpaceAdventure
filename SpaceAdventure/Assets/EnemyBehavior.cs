using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;
    void Start()
    {
        Hitpoints = MaxHitpoints;
    }
    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if (Hitpoints<= 0){
            Destroy(gameObject);
                } 
    } 
}
