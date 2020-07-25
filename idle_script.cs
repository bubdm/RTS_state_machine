using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle_script : MonoBehaviour
{

    base_behavior bb;

    // Start is called before the first frame update
    void Start()
    {
        bb = gameObject.GetComponent<base_behavior>();
    }

    private void OnDrawGizmos()
    {
        UnityEditor.Handles.Label(transform.position + Vector3.up * 3,"Idle");
    }


}
