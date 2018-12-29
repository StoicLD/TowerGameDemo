using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageWayPoints : MonoBehaviour
{
    public static Transform[] waypoints;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject ways = GameObject.FindGameObjectWithTag("waypoints");
        waypoints = new Transform[ways.transform.childCount];
        for (int i = 0; i < ways.transform.childCount; i++)
        {
            waypoints[i] = transform.GetChild(i);
        }
    }

}
