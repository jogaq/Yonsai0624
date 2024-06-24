using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimCtrl : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip FlashClip;
    public Animation Animation;
    public Light FlashLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharRun();
        CharLightOnOff();
    }

    private void CharRun()
    {
        if (
                Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            Animation.Play("running");
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Animation.Play("runStop");
        }
    }

    private void CharLightOnOff()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FlashLight.enabled = !FlashLight.enabled;
            AudioSource.PlayOneShot(FlashClip,0.6f);
        }


    }
}
