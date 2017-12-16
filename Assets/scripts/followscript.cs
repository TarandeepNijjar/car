using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followscript : MonoBehaviour {

    public Transform mTarget;
    public float difference;

    float kFollowSpeed = 5f;

    void Update()

    {
        if (mTarget != null)
        {

            Vector3 targetPosition = new Vector3(transform.position.x, mTarget.transform.position.y + 2, transform.position.z);
            transform.position = targetPosition;

        }

    }
}
