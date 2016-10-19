using UnityEngine;
using System.Collections;

public class SoundTriggerController : MonoBehaviour
{
    public AudioSource audioSourceEnter;
    public AudioSource audioSourceExit;

	// Use this for initialization
	void Start(){}
	
	// Update is called once per frame
	void Update(){}

    void OnTriggerEnter(Collider col)
    {
        audioSourceEnter.Play();
    }

    void OnTriggerExit(Collider col)
    {

    }

}
