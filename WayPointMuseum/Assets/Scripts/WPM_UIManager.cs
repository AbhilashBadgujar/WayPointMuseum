using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WPM_UIManager : WPM_Singleton<WPM_UIManager>
{


    [SerializeField] private GameObject CanvasObject;
    [SerializeField] private GameObject modelPanel;
    [SerializeField] private GameObject moreInfoPanel;

    [SerializeField] private TextMeshProUGUI modelPannelText;
    [SerializeField] private TextMeshProUGUI morePannelText;
    [SerializeField] private Image[] imageRenderer;
    [SerializeField] private GameObject[] models;
    [SerializeField] private Sprite[] images;

    // Start is called before the first frame update

    #region UI Interaction Call backs
    public void OpenModelPannel(int _modelNumber, String modelText, String moreText, Sprite[] sprites)
    {
        moreInfoPanel.SetActive(false);
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(false);
        }
        SetModelPanelText(modelText);
        SetMoreInoflPanelText(moreText);
        SetMoreInoflPanelImage(sprites);
        print(models[_modelNumber].gameObject.name);
        models[_modelNumber].SetActive(true);
        modelPanel.SetActive(true);
        CanvasObject.SetActive(true);

    }

    public void CloseModelPannel()
    {
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(false);
        }
        modelPanel.SetActive(false);
        moreInfoPanel.SetActive(false);
        CanvasObject.SetActive(false);
        WPM_ViewerManager.Instance.SetIsModelViewBool(false);
    }


    public void OpenMoreInfoPannel(){
        modelPanel.SetActive(false);
        moreInfoPanel.SetActive(true);
    }

    public void BackToModelPannel(){
        modelPanel.SetActive(true);
        moreInfoPanel.SetActive(false);
    }

    #endregion

    #region SetInfo for Info Pannel
    public void SetModelPanelText(String info){
        modelPannelText.text = info;
    }

    public void SetMoreInoflPanelText(String info){
        morePannelText.text = info;
    }


    public void SetMoreInoflPanelImage(Sprite[] _images){
        images = _images;
        for (int i = 0; i < imageRenderer.Length; i++)
        {
            imageRenderer[i].sprite = images[i];
        }
        
    }
    #endregion
}
