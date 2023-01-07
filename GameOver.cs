using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
  public Transform point;
  public GameObject over;

  public static void gameOver(){
    Debug.Log("working");
    Instantiate(over,point.position,Quaternion.identity);
    Application.Quit();
  }

}
