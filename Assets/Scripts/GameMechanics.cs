using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMechanics : MonoBehaviour
{
  private Scene currentScene;

  void Start()
  {
    currentScene = SceneManager.GetActiveScene();
  }

  void Update()
  {
    if(Input.GetKeyDown("r"))
    {
      SceneManager.LoadScene(currentScene.name);
    }
  }
}
