using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
  public GameObject dogPrefab;
  public float SpawnDelay = 2f;
  private bool canaccess = true;

  // Update is called once per frame
  void Update()
  {
    // On spacebar press, send dog
    if (Input.GetKeyDown(KeyCode.Space) && canaccess)
    {
      canaccess = false;
      Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
      Invoke("kuchbhi", SpawnDelay);
    }
  }
  void kuchbhi()
  {
    canaccess = true;
  }
}
