using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
  [SerializeField] private GameObject linkedPortal = null;

  [System.NonSerialized] public bool active = true;

  private void OnTriggerEnter2D(Collider2D collider)
  {
    if (!linkedPortal)
    {
      Debug.Log("ERROR: No linked portal.");
    }
    else if (active)
    {
      collider.gameObject.transform.position = linkedPortal.transform.position;
      linkedPortal.GetComponent<Portal>().active = false;
    }
  }

  private void OnTriggerExit2D(Collider2D collider)
  {
    active = true;
  }
}
