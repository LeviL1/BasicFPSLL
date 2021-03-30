using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableOBJ : MonoBehaviour, IDamage
{
    public void TakeDamage()
  {
    Destroy(gameObject);
  }
}
