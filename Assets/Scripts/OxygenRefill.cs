using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenRefill : MonoBehaviour
{
    private PlayerController playerController; // Reference to the player controller script
    private Animator animator; // Animator component attached to the current game object

    private void Start()
    {
        animator = GetComponent<Animator>(); // Get the animator component attached to the current game object
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered collision");
        if (other.CompareTag("Player"))
        {
            // Get the player controller script from the collided object
            playerController = other.GetComponent<PlayerController>();
           // animator.SetTrigger("pop"); // Trigger the "pop" animation on the current game object (bubble)
            // If the player controller script was found, refill the oxygen
            if (playerController != null)
            {
                playerController.currentOxygen = playerController.maxOxygen;
                //Destroy(gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("exit collision");
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("pop"); // Trigger the "pop" animation on the current game object (bubble)
            // If the player controller script was found, refill the oxygen
            Destroy(gameObject, .15f);
        }
    }
}




