using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankScript : MonoBehaviour
{
    public GameObject tankTurret;
    public Transform bulletSpawnPosition;
    public GameObject slider;

    [HideInInspector]
    public float health = 100;



    private void Update()
    {
        tankTurret.transform.rotation = Quaternion.Euler(0, 0, slider.GetComponent<Slider>().value);
    }

    /*public void OnAngleChange(float angularValue)
    {
        tankTurret.transform.rotation = Quaternion.Euler(0, 0, angularValue);
    }*/

    public void SetTankPosition(Vector3 spawnPosition)
    {
        transform.position = spawnPosition;
    }
}
