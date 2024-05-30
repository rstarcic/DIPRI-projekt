using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryInteraction : MonoBehaviour
{
    public string diaryTag = "Diary";
    public GameObject diaryCanvas;
    private bool diaryOpen = false;
    void Start()
    {
        diaryCanvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.transform.gameObject.CompareTag(diaryTag))
                {
                    Debug.Log("Kliknuto na dnevnik!");
                    if (!diaryOpen)
                    {
                        diaryCanvas.SetActive(true);
                        diaryCanvas.GetComponent<DisplayDiary>().ShowPage(0);
                    }
                    else 
                    {
                        diaryCanvas.SetActive(false); 
                        diaryOpen = false;
                    }
                }
                else
                {
                    Debug.Log("Kliknuto na objekt koji nije dnevnik: " + hit.transform.gameObject.name); // Ispisujemo u konzoli ime objekta koji je kliknut, ako nije dnevnik
                }
            }
        }
    }
}
