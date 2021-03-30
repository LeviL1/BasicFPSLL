using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealableOBJ : MonoBehaviour, IDamage
{
  public int health;
  public void TakeDamage()
  {
    if(health < 100)
    {
      health += 10;
      Debug.Log(health);
    }
    else
    {
      Debug.Log("Health At Max");
    }
    
  }
}
