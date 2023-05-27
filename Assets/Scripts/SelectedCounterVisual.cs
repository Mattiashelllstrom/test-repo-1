using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour {

  
    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObjectArray;

    private void Start() {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
          
            
            
            
            
           
    }

    public void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterchangedEventArgs e) {
        if (e.selectedCounter == baseCounter) {
            Show();
        } else {
            hide();
        }
    }

    private void Show() {
        foreach (GameObject visualGameObject in visualGameObjectArray) {
            visualGameObject.SetActive(true);
        }
    }
    private void hide() {
        foreach (GameObject visualGameObject in visualGameObjectArray) {
            visualGameObject.SetActive(false);
        }
    }
}
