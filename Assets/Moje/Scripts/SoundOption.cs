using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;

public class SoundOption : MonoBehaviour {
	public AudioMixer MasterAudioMixer;
	public string MixerVariableName;

    void Start()
    {
        var slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(ChangeVolume);
        var value = PlayerPrefs.GetFloat(MixerVariableName, 1);
        slider.value = value;
		ChangeVolume(value);
    }

    private void ChangeVolume(float value) {
	    var volume = CalculateVolume(value);
	    MasterAudioMixer.SetFloat(MixerVariableName, volume);
		PlayerPrefs.SetFloat(MixerVariableName, value);
    }

    private static float CalculateVolume(float value) {
	    float volume;
	    if (value > 0)
		    volume = 20 * Mathf.Log(value);
	    else
		    volume = -80f;
	    return volume;
    }
}
