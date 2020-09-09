using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollbarTestDLG : MonoBehaviour
{
    [SerializeField] Scrollbar m_scrollbar = null;
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult = null;
    [SerializeField] Button m_btnClear = null;
    // Start is called before the first frame update
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
    }
    public void Init()
    {

    }
    public void OnValueChanged()
    {
        string strValue = "" + (int)(m_scrollbar.value*100);
        m_txtResult.text = strValue;
    }
    public void OnClicked_Result()
    {
        float fValue = (int)(m_scrollbar.value * 100);
        string strResult = "현재 진행된 값은<color=#7fffd4> " + fValue + "</color> 입니다.";
        m_txtResult.text = strResult;
    }
    public void OnClicked_Clear()
    {
        m_scrollbar.value = 0;
        m_txtResult.text = "";

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
