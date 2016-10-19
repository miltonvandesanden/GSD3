using UnityEngine;
using System.Collections;

public class RunningPersonTriggerController : MonoBehaviour
{
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onTriggerEnter(Collider collider)
    {
        print("RUN");
        while(transform.position.z != 15)
        {
            transform.Translate(transform.position.x, transform.position.y, transform.position.z + 1);
        }
    }
}
