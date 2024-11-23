using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitboxController : MonoBehaviour
{
    public bool colliding;

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "GrindBox") {
            Debug.Log("hitbox contact");
            colliding = true;
        }
    }
}