using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyhole : MonoBehaviour
{
  [SerializeField] private GameObject key = null;
  [SerializeField] private GameObject door = null;

  private Collider2D keycollider;

  void Start()
  {
    keycollider = key.GetComponent<BoxCollider2D>();
  }

  private void OnTriggerEnter2D(Collider2D collider)
  {
    if (collider == keycollider)
    {
      door.SetActive(false);
    }
  }

  private void OnTriggerExit2D(Collider2D collider)
  {
    if (collider == keycollider)
    {
      door.SetActive(true);
    }
  }
}
