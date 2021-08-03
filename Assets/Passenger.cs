using System.Collections;
using UnityEngine;

public class Passenger : MonoBehaviour {
  void OnEnable() {
    StartCoroutine(HideTalkBubble(6));
  }

  IEnumerator HideTalkBubble(float delay) {
    yield return new WaitForSeconds(delay);
    Utils.Find("Talk bubble").SetActive(false);
  }
}
