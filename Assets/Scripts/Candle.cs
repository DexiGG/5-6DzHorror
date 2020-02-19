using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
   [SerializeField]
    private Light pointLight;
    private bool isOn;
    

    void Start()
   {
      isOn = false;
      // отключаем свет от свечи
      pointLight.gameObject.SetActive(false);
   }

   public void ChangeLight()
   {
      // меняем true на false и наоборот 
      isOn = !isOn;
      // попеременно включаем/выключаем свет в зависимости от значения переменной isLight
      pointLight.gameObject.SetActive(isOn);
   }

}

