using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CowMove : MonoBehaviour
{
    public NavMeshAgent cowNav;
    public GameObject target;

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("I collided");
        if (col.gameObject.GetComponent<PlayerMove>())
        {
            target = col.gameObject;
            Debug.Log("Target Aquired");
        }
    }


    void Update()
    {
        if (target != null)
        {
            cowNav.SetDestination(target.transform.position);
        }
    }
}
