using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitboxController : MonoBehaviour
{
    public bool colliding;

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "PlayerHitbox" || col.gameObject.tag == "DashHitbox") {
            Debug.Log("enemy hurt");
            colliding = true;
        }
    }
}
