using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour {

    public float force = 1f;

    // Update is called once per frame
    public void splatter () {
        if (Input.anyKey) {
            foreach (Transform child in transform)
            {
                child.GetComponent<Rigidbody2D>().AddForce((child.position - transform.position).normalized * force);
            }
        }
		
	}
}
