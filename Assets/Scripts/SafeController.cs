using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SafeController : MonoBehaviour
{
    public string correctCode = "210523";
    private string currentInput = "";

    public TMP_Text displayText;  
    public Animator safeAnimator;
    public GameObject keypad;
    public GameObject safe;
 
    public Camera mainCamera;
    public Camera zoomCamera;


    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == safe)
                {
                   OpenSafe();
                }
                if (hit.collider.CompareTag("Keypad"))
                {
                    Debug.LogWarning("Keypad clicked.");
                    if (zoomCamera != null)
                    {
                        mainCamera.enabled = false;
                        zoomCamera.enabled = true;
                    }
                }
                else
                {
                    Debug.LogWarning("Keypad not clicked.");
                }
            }   
        }
    }
    public void OnSafeClicked()
    {
        keypad.SetActive(true);
    }

    public void OnNumberButtonPressed(string number)
    {
        if (currentInput.Length < 6)
        {
            currentInput += number;
            UpdateDisplay();
        }
    }

    public void OnEnterButtonPressed()
    {
        if (currentInput == correctCode)
        {
            OpenSafe();
        }
        else
        {
            currentInput = "";
            UpdateDisplay();
        }
    }

    private void UpdateDisplay()
    {
        displayText.text = currentInput;
    }

    public void OpenSafe()
    {
        keypad.SetActive(true);
        safeAnimator.SetBool("isOpen", true);
    }
}
