using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    Transform[] Spaces;
    public List<Transform> spaceList = new List<Transform>();

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
    }
}
