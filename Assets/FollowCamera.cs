using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //camera position position should be the same as the car
    [SerializeField] GameObject thingToFollow;

    
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0, -10);
    }
}
