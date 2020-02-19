using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangeZone : MonoBehaviour
{
   [SerializeField]
    private Light flashLight;

    [SerializeField]
    private AudioClip audioClip;

    private AudioSource _audio;

    private void Start() {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "StrangeZone")
        {
            gameObject.GetComponent<FlashLight>().enabled = false;
            flashLight.enabled = false;
            _audio.Play();
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "StrangeZone")
        {
            gameObject.GetComponent<FlashLight>().enabled = true;
            _audio.Stop();
        }
    }
}
