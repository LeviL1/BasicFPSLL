using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{
  // Start is called before the first frame update
  public int health;
  public bool isDestroyed = false;
  public void TakeDamage()
  {
    health -= 10;
    if(health <= 0)
    {
      
      Destroy(gameObject);
      isDestroyed = true;
    }
  }
}
