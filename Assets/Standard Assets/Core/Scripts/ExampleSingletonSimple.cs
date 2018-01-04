using UnityEngine;

public class ExampleSingletonSimple : MonoBehaviour {

  static ExampleSingletonSimple reference;
  public static ExampleSingletonSimple instance {
    get {
      if (reference == null) {
        reference = new GameObject("Simple Singleton").AddComponent<ExampleSingletonSimple>();
      }
      return reference;
    }
  }
}