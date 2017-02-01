using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    AudioClip audioClip;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioClip = Resources.Load("click") as AudioClip;
        audioSource = gameObject.AddComponent<AudioSource>();

        if (this.tag == "Sphere1")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-600.0f, 0.0f, 0.0f));
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        float audioLevel = collision.relativeVelocity.magnitude / 10.0f;
        audioSource.PlayOneShot(audioClip, audioLevel);
    }
}
