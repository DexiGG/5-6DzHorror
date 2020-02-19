using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class HealthHero : MonoBehaviour
{
    [SerializeField]
    private float maxHealthPoint;

    [SerializeField]
    private Image healthIndecator;

    private float currentHealthPoint;

    private void Start()
    {
        currentHealthPoint = maxHealthPoint;
    }
    private void Update()
    {
        if(currentHealthPoint > 0)
        {
            Vector3 healthSize = new Vector3(currentHealthPoint / maxHealthPoint,1,1);
            healthIndecator.transform.localScale = healthSize;
            return;
        }

        gameObject.GetComponent<RigidbodyFirstPersonController>().enabled = false;
      
    }


    public void Heal(float health)
    {
        currentHealthPoint += health;
    }

    public void Heal()
    {
        currentHealthPoint = maxHealthPoint;
    }

}
