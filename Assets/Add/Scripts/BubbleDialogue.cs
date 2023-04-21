/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BubbleDialoge : MonoBehaviour
{
    public GameObject box;
    public TextMeshProUGUI displayText;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    static bool dialogShown = false;
    public GameObject player;
    // public Animator displayTextAnim;
    //private bool completeDialogues = false;

    private void Start()
    {
        box.SetActive(false);
        //displayText = GetComponent<TextMeshProUGUI>();

    }

    
    void Update()
    {
        if (displayText.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            if (!dialogShown)
            {
               // player.SetActive(false);
                StartCoroutine(Type());
               // box.SetActive(true);
            }
        }
    }
    IEnumerator Type()
    {
        yield return new WaitForSeconds(0f);
        box.SetActive(true);
        //player.SetActive(false);
        foreach (char letter in sentences[index].ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        //displayTextAnim.SetTrigger("change");
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            displayText.text = "";
            StartCoroutine(Type());
        }
        else
        {
            displayText.text = "";
            continueButton.SetActive(false);
            box.SetActive(false);
            player.SetActive(true);
        }
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BubbleDialogue : MonoBehaviour
{
    public GameObject box;
    public TextMeshProUGUI displayText;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    
    public GameObject player;
    static bool dialogShown = false;
    private void Start()
    {
        //box.SetActive(false);
    }

    void Update()
    {
        if (displayText.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!dialogShown)
            {
                dialogShown = true;
                player.SetActive(false);
                StartCoroutine(Type());
            }
        }
    }

    IEnumerator Type()
    {
        yield return new WaitForSeconds(0.5f);
        box.SetActive(true);
        foreach (char letter in sentences[index].ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            displayText.text = "";
            StartCoroutine(Type());
        }
        else
        {
            displayText.text = "";
            continueButton.SetActive(false);
            box.SetActive(false);
            player.SetActive(true);
            //dialogShown = false;
            //Destroy(bubble);
           

        }
    }
}
