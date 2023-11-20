using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    private List<IChangeable> _changeableObjects = new List<IChangeable>();

    public List<GameObject> ChangeableObjects;

    private void Start()
    {
        for (int x = 0; x < ChangeableObjects.Count; x++)
        {
            var changeableObject = ChangeableObjects[x].GetComponent<IChangeable>();
            _changeableObjects.Add(changeableObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            for(int x = 0; x < _changeableObjects.Count; x++)
            {
                _changeableObjects[x].Next();
            }
        }
    }
}
