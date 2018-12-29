using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Transform currentWayPoint;
    public int waypointIndex;

    int indexLength;
    //public GameObject[] waypoints;
    void Start()
    {
        waypointIndex = 0;
        currentWayPoint = ManageWayPoints.waypoints[0];
        indexLength = ManageWayPoints.waypoints.Length;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTopWayPoints();
    }

    void MoveTopWayPoints()
    {
        if (waypointIndex >= indexLength)
        {
            Destroy(this.gameObject);
            return;
        }
        else if (Mathf.Abs(Vector3.Distance(this.transform.position, currentWayPoint.position)) < 0.25 )
        {
            waypointIndex++;
            currentWayPoint = ManageWayPoints.waypoints[waypointIndex];
        }
        else
        {
            Vector3 direction = Vector3.Normalize(transform.position - currentWayPoint.position);
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
