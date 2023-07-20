using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioClip swing;
    [SerializeField] private AudioClip bombexplode;

    private Vector3 position = Vector3.zero;

    private AudioClip fruitSliceSound;
    private AudioClip bombExplode;

    public void Awake() {
        Instance = this;
        fruitSliceSound = swing;
        bombExplode = bombexplode;
    }

    public void PlaySoundSwing() {
        AudioSource.PlayClipAtPoint(fruitSliceSound, position);
    }
    public void PlaySoundBombExplode() {
        AudioSource.PlayClipAtPoint(bombExplode, position);
    }
}
