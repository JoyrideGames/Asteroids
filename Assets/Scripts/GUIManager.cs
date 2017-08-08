using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{

    #region Variables
    public Slider volumeSlider, brightnessSlider;
    public AudioSource music;
    public bool gameScene, showOptions, showMenu;
    public GameObject menu, options;
    public Light dirLight;
    #endregion

    #region Play, Exit, Save, Load, Reset
    public void Play()
    { SceneManager.LoadScene(1); }
    public void Exit()
    { Application.Quit(); Debug.Log("Quit"); }
    public void Save()
    {
        PlayerPrefs.SetFloat("Volume", music.volume);
        PlayerPrefs.SetFloat("Brightness", dirLight.intensity);
    }
    public void Load()
    {
        music.volume = PlayerPrefs.GetFloat("Volume");
        dirLight.intensity = PlayerPrefs.GetFloat("Brightness");
    }
    public void Reset()
    {
        volumeSlider.value = 1;
        brightnessSlider.value = 1;
    }
    #endregion

    void Start()
    {
        volumeSlider.GetComponent<Slider>().value = music.volume;
        if (PlayerPrefs.HasKey("Volume")) { Load(); }
        if (PlayerPrefs.HasKey("Brightness")) { Load(); }
        if (volumeSlider != null && music != null)
        { volumeSlider.value = music.volume; }
        if (brightnessSlider != null && dirLight != null)
        { brightnessSlider.value = dirLight.intensity; }
    }

    void Update()
    {
        #region Sliders

        if (volumeSlider != null && music != null)
        {
            volumeSlider.value = music.volume;
            { music.volume = volumeSlider.value; }
        }
        if (brightnessSlider != null && dirLight != null)
        {
            brightnessSlider.value = dirLight.intensity;
            { dirLight.intensity = brightnessSlider.value; }
        }
        #endregion

      /*  if (showOptions)
        {
            if (music.volume != volumeSlider.GetComponent<Slider>().value)
                music.volume = volumeSlider.GetComponent<Slider>().value;
        }
        */
    }

    public void ShowOptions()
    {
        
        
            ToggleOptions();
        
    }
    public bool ToggleOptions()
    {
        if (showOptions)
        {
            
            showOptions = false;
            options.SetActive(true);
            return true;
        }
        else
        {
            
            showOptions = true;
            options.SetActive(false);
            return false;
        }
    }
    public void ShowMenu()
    {
        ToggleMenu();
    }
    public bool ToggleMenu()
    {
        
            if (showMenu)
            {
                showMenu = false;
                menu.SetActive(true);
                return true;
            }
         else
            {
                showMenu = true;
                menu.SetActive(false);
                return false;
            }
        }

    void FixedUpdate()
    {
        if (showOptions)
        {
            music.volume = volumeSlider.value;
        }
        if (showOptions)
        {
            dirLight.intensity = brightnessSlider.value;
        }
    }
    }
