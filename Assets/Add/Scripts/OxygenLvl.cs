using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OxygenLvl : MonoBehaviour
{
    public PlayerController oxygenLvl;
    public Image fillImage;

    private Slider oxygenSlider;
    
    private void Start()
    {
        oxygenSlider = GetComponent<Slider>();
       // oxygenSlider = fillImage.GetComponent<Slider>();
        oxygenSlider.maxValue = 10f;
    }

    private void Update()
    {
        float fillValue = oxygenLvl.currentOxygen;
        oxygenSlider.value = fillValue;
        if (oxygenSlider.value <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
