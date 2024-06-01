using UnityEngine;
using UnityEngine.UI;

public class SoundsManagement : MonoBehaviour
{
    public Slider themeSlider;
    public Slider sfxSlider;
    private string themeSoundName = "BG";
    private string sfxSoundName = "Shot";

    void Start()
    {
        themeSlider.value = AudioManager.instance.GetVolume(themeSoundName);
        sfxSlider.value = AudioManager.instance.GetVolume(sfxSoundName);

        themeSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(themeSoundName, themeSlider.value); });
        sfxSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(sfxSoundName, sfxSlider.value); });
    }

    void OnSliderValueChanged(string soundName, float value)
    {
        AudioManager.instance.SetVolume(soundName, value);
    }
}
