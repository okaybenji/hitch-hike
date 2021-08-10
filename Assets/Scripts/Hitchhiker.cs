using System.Collections;
using UnityEngine;

public class Hitchhiker : MonoBehaviour {
  GameObject _passenger;
  GameObject _talkBubble;
  GameObject _radio;
  void OnEnable() {
    _passenger = Utils.Find("Passenger");
    _radio = Utils.Find("Radio");
  }

  void OnTriggerEnter() {
    // Show the passenger.
    _passenger.SetActive(true);

    // Play the sound of them getting in the car.
    _passenger.GetComponent<AudioSource>().Play();

    // Start up the radio music.
    _radio.GetComponent<RadioController>().Play();

    // Hide the hitchhiker.
    gameObject.SetActive(false);
  }
}
