using UnityEngine;
using System.Collections;

public class RunningPersonTriggerController : MonoBehaviour
{
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
	    //print("BLUB");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        audioSource.Play();
    }
}
