using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] private Slider soundSlider;
    [SerializeField] private AudioMixer masterMixer;
    
    // Start is called before the first frame update
    private void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("SavedMasterVolume",100));
    }

    public void SetVolume(float _value){
        if(_value < 1){
            _value = .001f;
        }
        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedMasterVolume",_value);
        masterMixer.SetFloat("MasterVolume",Mathf.Log10(_value / 100)* 20f);

    }

   public void SetVolumeFromSlider(){
    SetVolume(soundSlider.value);
   }
   public void RefreshSlider(float _value){
    soundSlider.value = _value;
   }
}
