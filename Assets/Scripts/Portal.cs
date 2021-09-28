using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
  [SerializeField] private GameObject linkedPortal = null;

  private void OnTriggerEnter2D(Collider2D collider)
  {
    collider.gameObject.transform.position = linkedPortal.transform.position;
  }
}
