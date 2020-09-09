using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTestDLG : MonoBehaviour
{
    [SerializeField] Slider m_Slider = null;
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult = null;
    [SerializeField] Button m_btnClear = null;
    [SerializeField] int minVal = 0;
    [SerializeField] int maxVal = 100;
    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
        Init();
    }
    public void Init()
    {
        m_Slider.minValue = minVal;
        m_Slider.maxValue = maxVal;
        m_Slider.value = 0;

    }
    public void OnValueChanged()
    {
        string strValue = "" + (int)m_Slider.value;
        m_txtResult.text = strValue;
    }
    public void OnClicked_Result()
    {
        float fValue = (int)m_Slider.value;
        string strResult = "현재 진행된 값은<color=#7fffd4> " + fValue + "</color> 입니다.";
        m_txtResult.text = strResult;
    }
    public void OnClicked_Clear()
    {
        m_Slider.value = 0;
        m_txtResult.text = "";

    }
    public void OnClicked_clear()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
