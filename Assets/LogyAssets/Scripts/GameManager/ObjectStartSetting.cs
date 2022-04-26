using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStartSetting : MonoBehaviour {
    [SerializeField] private Objects[] OpenObjects;
    [SerializeField] private Objects[] CloseObjects;
    [SerializeField] private StartPosition[] startPositions;
    private void Awake() {
        byte i, j;

        for(i = 0; i < OpenObjects.Length; i++) {
            for(j = 0; j < OpenObjects[i].gameObjects.Length; j++) {
                OpenObjects[i].gameObjects[j].SetActive(true);
            }
        }

        for(i = 0; i < CloseObjects.Length; i++) {
            for(j = 0; j < CloseObjects[i].gameObjects.Length; j++) {
                CloseObjects[i].gameObjects[j].SetActive(false);
            }
        }

        for(i = 0; i < startPositions.Length; i++) {
            startPositions[i].transform.localPosition = startPositions[i].startPosition;
        }
    }
}