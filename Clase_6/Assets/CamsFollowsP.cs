using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamsFollowsP : MonoBehaviour
{
    public Transform tfm;
    void LateUpdate()
    {
        transform.position = new Vector3(tfm.position.x, tfm.position.y, tfm.position.z-1f);      
    }
    
}
