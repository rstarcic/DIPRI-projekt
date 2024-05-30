using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDiary : MonoBehaviour
{

    public GameObject diaryPages;
    public GameObject diaryCanvas;
    public Button previousButton; 
    public Button nextButton;

    private int currentPageIndex = 0;

    void Start()
    {
        ShowPage(currentPageIndex);
        previousButton.onClick.AddListener(ShowPreviousPage);
        nextButton.onClick.AddListener(ShowNextPage);
    }

    void ShowPreviousPage()
    {
        currentPageIndex--;
        if (currentPageIndex < 0)
            currentPageIndex = diaryPages.transform.childCount - 1; 
        ShowPage(currentPageIndex);
    }

    void ShowNextPage()
    {
        currentPageIndex++;
        if (currentPageIndex >= diaryPages.transform.childCount)
            currentPageIndex = 0; 
        ShowPage(currentPageIndex);
    }

    public void ShowPage(int index)
    {
        for (int i = 0; i < diaryPages.transform.childCount; i++)
        {
            diaryPages.transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }
}
