using UnityEngine;

public class ExampleSingleton {
  static IExampleSingleton reference;
  public static IExampleSingleton instance {
    get {
      if (reference == null) {
        if (Application.platform == RuntimePlatform.Android) {
          reference = new GameObject("Android Example Singleton").AddComponent<ExampleSingletonAndroid>();
        }
        else {
          reference = new GameObject("iOS Example Singleton").AddComponent<ExampleSingletonIOS>();
        }
      }
      return reference;
    }
  }
}
public interface IExampleSingleton {
  void AddValue(int number);
}
public class ExampleSingletonAndroid : MonoBehaviour, IExampleSingleton {
  int value;
  public void AddValue(int number) {
    value += number * 2;
  }
}
public class ExampleSingletonIOS : MonoBehaviour, IExampleSingleton {
  int value;
  public void AddValue(int number) {
    value += number;
  }
}