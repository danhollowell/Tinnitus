using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderController : MonoBehaviour {
    public Slider volumeSlider;
    public AudioSource[] volumeAudio;
    public void OnValueChanged()
    {
        for (int i =  0; i< volumeAudio.Length; i++)
        {
            volumeAudio[i].volume = volumeSlider.value ;
        }
        
    }
}
