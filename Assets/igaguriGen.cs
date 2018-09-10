using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguriGen : MonoBehaviour
{
    public GameObject igaguriPrefab;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worlddir = ray.direction;

            Vector3 wind = new Vector3(Random.Range(-50.0f, 50.0f), Random.Range(-50.0f, 50.0f), 0.0f);

            igaguri.GetComponent<igaguriController>().shoot((worlddir.normalized * 2000.0f) + wind);
        }
	}
}
