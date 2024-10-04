using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Core : MonoBehaviour
{
    private readonly List<CoreComponent> CoreComponents = new List<CoreComponent>();

    private void Awake()
    {
        
    }

    public void LogicUpdate()
    {
        foreach (CoreComponent item in CoreComponents)
        {
            item.LogicUpdate();
        }
    }

    public void AddComponent(CoreComponent component)
    {
        if(!CoreComponents.Contains(component))
        {
            CoreComponents.Add(component);
        }
    }


    public T GetCoreComponent<T>()where T: CoreComponent
    {
        var comp = CoreComponents.OfType<T>().FirstOrDefault();

        if(!comp)
        {
            comp = GetComponentInChildren<T>();
            if(!comp)
            {
                Debug.LogWarning($"{typeof(T)} not found in {transform.parent.name} ");
                return null;
            }
        }
        return comp;
    }
    public T GetCoreComponent<T>(ref T value) where T : CoreComponent
    {
        value = GetCoreComponent<T>();
        return value;
    }
}
