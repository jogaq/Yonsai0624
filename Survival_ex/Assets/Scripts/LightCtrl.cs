using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightCtrl : MonoBehaviour
{
    public Light TopLgiht;
    public AudioClip LightClip;
    public AudioSource LightSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TopLgiht.enabled = true;
            LightSource.PlayOneShot(LightClip,0.6f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TopLgiht.enabled = false;
            LightSource.PlayOneShot(LightClip, 0.6f);
        }
    }
}
