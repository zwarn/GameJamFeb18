using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackToFront : MonoBehaviour {

    public void MoveBack()
    {
        transform.SetAsFirstSibling();
    }

    public void MoveFront()
    {
        transform.SetAsLastSibling();
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MoveBack();
        }
    }
}
