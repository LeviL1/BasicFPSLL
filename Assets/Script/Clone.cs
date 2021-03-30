using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour, IDamage
{
  public GameObject clone;
  public void TakeDamage()
  {
    
   

      clone = Instantiate(clone, new Vector3(Random.Range(1f, 3f), Random.Range(1f, 3f),
                          Random.Range(1f, 3f)), Quaternion.identity);
    


  }
  void Update()
  {
    if (Input.GetMouseButtonDown(1))
    {

      RaycastHit hit;
      
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if (Physics.Raycast(ray, out hit))
      {
        Transform objectHit = hit.transform;
        clone = hit.transform.gameObject;


      }
    }

  }
}

