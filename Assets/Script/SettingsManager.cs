using UnityEngine;
using UnityEngine.UI;

// tambah script disini untuk script audio -udh
// trs nambah pause dipojok atas harus 0
// buttonnya kebalik antara exit dan setting -udh
// buat input mobile apasi yg buat ngarahin itu
public class SettingsManager : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = AudioListener.volume;
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}