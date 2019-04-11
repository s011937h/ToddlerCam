using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour {

    MeshRenderer _renderer;
    int _materialIndex;
    public Material[] _material;

	// Use this for initialization
	void Start ()
    {
        _renderer = GetComponent<MeshRenderer>();
        _materialIndex = 0;
        _renderer.material = _material[_materialIndex];
	}
	
    void ChangeMaterial()
    {
        _materialIndex++;
        if(_materialIndex > _material.Length - 1)
        {
            _materialIndex = 0;
        }
        _renderer.material = _material[_materialIndex];
    }

    private void OnCollisionEnter(Collision collision)
    {
        ChangeMaterial();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
