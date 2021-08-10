using UnityEngine;

public class RadioController : MonoBehaviour {
  public void Play() {
    GetComponent<AudioSource>().Play();
  }
}
