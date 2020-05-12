using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointDetection : MonoBehaviour
{
    [SerializeField] GameObject leftWayPoint;
    [SerializeField] GameObject rightWayPoint;
    private Transform enemyPosition;
    private EnemyMovement enemyMovement;
    

    private void Start()
    {
        enemyPosition = GetComponent<Transform>();
        enemyMovement = GetComponent<EnemyMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        if (enemyPosition.position.x <= leftWayPoint.transform.position.x || enemyPosition.position.x >= rightWayPoint.transform.position.x)
        {
            enemyMovement.flipSpeed();
        }
    }
}
