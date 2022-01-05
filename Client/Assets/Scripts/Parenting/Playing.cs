using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
using Controller;

namespace Parenting
{
    public class Playing : MonoBehaviour
    {
        public PopUpManager popUpManager;
        public PopUp playingPopup;
        public MotiveController motiveController;

        private void Awake()
        {
        }
        
        private void Update()
        {
        }

        private void OnMouseUpAsButton()
        {
            Debug.Log("playing is clicked");
            popUpManager.ColliderClickAction(playingPopup);
            Time.timeScale = 0f;            

        public void CheckAvailable(PlayingObject playingObject)
        {
            if (motiveController.DoesEnergyLack())
            {
                Debug.Log("Baby doesn't have energy much as to play!");                
            }
            else
            {
            }
        }
    }
}