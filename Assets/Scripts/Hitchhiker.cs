using System.Collections;
using UnityEngine;

public class Hitchhiker : MonoBehaviour {
  GameObject _passenger;
  GameObject _talkBubble;
  GameObject _radio;

  void OnEnable() {
    // e.g. Hitch-Hiker "Kev"'s Passenger GameObject will be called "Kev2"
    _passenger = Utils.Find(gameObject.name + "2");
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
