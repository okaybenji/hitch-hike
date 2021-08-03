using UnityEngine;

public class Utils {
// Finds a GameObject by name, regardless of Active status.
  public static GameObject Find(string name) {
    Transform[] objs = UnityEngine.Object.FindObjectsOfType<Transform>(true);
    for (int i = 0; i < objs.Length; i++) {
      if (objs[i].name == name) {
        return objs[i].gameObject;
      }
    }

    return null;
  }
}
