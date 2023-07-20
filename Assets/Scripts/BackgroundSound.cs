using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    [SerializeField] private float volume;

    public void Start() {
        GetComponent<AudioSource>().volume = volume;
    }
}
