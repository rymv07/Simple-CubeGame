using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement pmovement;

    private void OnTriggerEnter()
    {
        gameManager.completeLevelUI.SetActive(true);
        pmovement.enabled = false;
    }
}
