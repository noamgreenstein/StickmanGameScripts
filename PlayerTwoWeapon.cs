using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoWeapon : MonoBehaviour
{
  public Transform firepoint;
  public GameObject bullet;

  // Update is called once per frame
  void Update()
  {
    if(Input.GetButtonDown("Fire2")){
      Shoot();
    }
  }

  void Shoot(){
    Instantiate(bullet,firepoint.position,firepoint.rotation);
  }
}
