using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioPlayer : MonoBehaviour
{
    public AudioMixerSnapshot snapshotCalm;
    public AudioMixerSnapshot snapshotIntense;
    public AudioMixerSnapshot snapshot3;
    public AudioMixerSnapshot snapshot4;
    public AudioMixerSnapshot snapshot5;
    public AudioMixerSnapshot snapshot6;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Calm")
        {
           snapshotCalm.TransitionTo(1f);
        }
        if (other.gameObject.tag == "Intense")
        {
            snapshotIntense.TransitionTo(1f);

        }
        if (other.gameObject.tag == "Relaxing")
        {
            snapshot3.TransitionTo(1f);
        }
        if (other.gameObject.tag == "GuitarHero")
        {
            snapshot4.TransitionTo(1f);
        }
        if (other.gameObject.tag == "Peanut")
        {
            snapshot5.TransitionTo(1f);
        }
        if (other.gameObject.tag == "Peanut")
        {
            snapshot6.TransitionTo(1f);
        }
    }
}
