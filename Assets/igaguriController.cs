using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguriController : MonoBehaviour
{

    bool ishit = false;
    float time = 0.0f;

    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();

        ishit = true;
    }

    // Use this for initialization
    void Start ()
    {
        // shoot(new Vector3(0.0f, 200.0f, 2000.0f));
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(ishit)
        {
            this.time += Time.deltaTime;
            if( this.time > 2.0f)
            {
                Destroy(gameObject);
            }
        }
	}
}
