using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletService : MonoBehaviour
{
    public GameObject powerSlider;
    public GameObject bullet;
    public BulletView bulletView;

    public GameObject angleSlider;
    
    

    
    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletView = spawnedBullet.GetComponent<BulletView>();
        bulletView.SetBulletAngle(angleSlider.GetComponent<Slider>().value);
        bulletView.FireBullet(powerSlider.GetComponent<Slider>().value);

    }

   
   
        
  
}

