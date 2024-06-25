using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteInteractionScript : MonoBehaviour
{
    public GameObject note;
    public GameObject picture;
    public Animator doorAnimator;
    public TextMeshProUGUI messageText;
    private float messageDuration = 3.0f;
    public AudioSource audioSource;
    public AudioClip clip;


    void Start()
    {
        note.SetActive(true);
        messageText.gameObject.SetActive(false);
        picture.SetActive(false);
    }

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Note"))
        {
            OnNoteClicked();
        }
    }

    public void OnNoteClicked()
    {
        InvManager InvManager = GameObject.FindObjectOfType<InvManager>();
        if (InvManager.HasItem(7))
        {
            note.SetActive(false);
            picture.SetActive(true);
            InvManager.Remove(7);
            doorAnimator.SetTrigger("Open");
            audioSource.PlayOneShot(clip);
        }
        else
        {
            ShowMessage("You need to find a picture.");
        }
    }

    private void ShowMessage(string text)
    {
        messageText.text = text;
        messageText.gameObject.SetActive(true);
        Invoke("HideMessage", messageDuration);
    }
    private void HideMessage()
    {
        messageText.gameObject.SetActive(false);
    }
}
