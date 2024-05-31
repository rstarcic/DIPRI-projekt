using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDiary : MonoBehaviour
{

    public Image diaryImage;
    public List<Sprite> diaryPages;
    public GameObject diaryCanvas;
    public Button previousButton; 
    public Button nextButton;
    public Button closeButton;

    private int currentPageIndex = 0;

    void Start()
    {
        if (diaryPages.Count > 0)
        {
            ShowPage(currentPageIndex);
        }
        previousButton.onClick.AddListener(ShowPreviousPage);
        nextButton.onClick.AddListener(ShowNextPage);
        closeButton.onClick.AddListener(CloseDiary);
    }

    void ShowPreviousPage()
    {
        currentPageIndex--;
        if (currentPageIndex < 0)
            currentPageIndex = diaryPages.Count - 1; 
        ShowPage(currentPageIndex);
    }

    void ShowNextPage()
    {
        currentPageIndex++;
        if (currentPageIndex >= diaryPages.Count)
            currentPageIndex = 0; 
        ShowPage(currentPageIndex);
    }

    public void ShowPage(int index)
    {
        if (index >= 0 && index < diaryPages.Count)
        {
            diaryImage.sprite = diaryPages[index];
        }
    }
    public void CloseDiary()
    {
        diaryCanvas.SetActive(false);
    }
}
