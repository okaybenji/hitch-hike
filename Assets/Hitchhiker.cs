using System.Collections;
using UnityEngine;

public class Hitchhiker : MonoBehaviour {
  GameObject _passenger;
  GameObject _talkBubble;
  void OnEnable() {
    _passenger = Utils.Find("Passenger");
  }

  void OnTriggerEnter() {
    _passenger.SetActive(true);
    _passenger.GetComponent<AudioSource>().Play();
    gameObject.SetActive(false);
  }
}
