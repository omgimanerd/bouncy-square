using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

  private static GameManager instance;

  [SerializeField]
  private Color[] colors;

  void Awake() {
    if (instance == null) {
      instance = this;
    }
  }

  public static GameManager GetInstance() {
    return instance;
  }

  public Color[] GetColors() {
    return colors;
  }
}
