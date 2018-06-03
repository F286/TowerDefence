using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;

public interface IInjectable {
}

public abstract class InjectBehaviour : MonoBehaviour, IInjectable {
	public virtual void Awake() {
		Inject();
	}
	public virtual void OnEnable() {
		Inject();
	}

  protected void Inject() {
		var type = this.GetType();
		var fields = type.GetFields(BindingFlags.NonPublic | 
																BindingFlags.Public |
																BindingFlags.Instance);

		foreach (var field in fields) {
			var getValue = field.GetValue(this);
			
			if (getValue == null && typeof(IInjectable).IsAssignableFrom(field.FieldType)) {
				field.SetValue(this, FindInstance(field));
			}
		}

	}

	object FindInstance(FieldInfo field) {
		var type = field.FieldType;

		object instance = GameObject.FindObjectOfType(type);

		if (instance == null) {
			var templateName = type.Name;
			var templateMethod = type.GetMethod("Template");
			if (templateMethod != null) {
				templateName = (string)templateMethod.Invoke(null, null);
			}
			var load = Resources.Load<GameObject>(templateName);
			var copy = GameObject.Instantiate(load);
			copy.name = load.name;
			instance = copy.GetComponent(type);
		}

		return instance;
	}
}
