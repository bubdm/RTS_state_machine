using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seek_script : MonoBehaviour
{
    base_behavior bb;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        bb = gameObject.GetComponent<base_behavior>();
        target = bb.target;
    }

    // Update is called once per frame
    void Update()
    {
        seekPoint();
    }

    void seekPoint() //move towards the target
    {
        if((target.transform.position - transform.position).magnitude > 10.0f)
        {
            transform.position += (target.transform.position - transform.position).normalized * 0.3f;
        }
        else
        {
            bb.changeState(base_behavior.UnitFSM.Idle);
        }
    }

    private void OnDrawGizmos()
    {
        UnityEditor.Handles.Label(transform.position + Vector3.up * 3, "Seek");
    }

}
