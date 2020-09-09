using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TogglegroutTestDLG : MonoBehaviour
{
    [SerializeField] ToggleGroup m_toggleGroup = null;
    [SerializeField] Text m_txtResult = null;
    [SerializeField] Button m_btnResult = null;

    string sValue = null;
    // Start is called before the first frame update
    static string[] aName = { "사과", "배", "오렌지" };
    void Start()
    {
        m_btnResult.onClick.AddListener(OnClicked_Result);
        sValue = "사과";

    }
    public void OnClicked_Result()
 {
        string strResult = "당신이 선택한 과일은 " + sValue + " 입니다.";
        m_txtResult.text = strResult;
}

    public void OnChanged_Toggle(int iIndex)
    {
        sValue = aName[iIndex];
    }

    public void OnClicked_clear()
    {
        m_toggleGroup.SetAllTogglesOff();
        m_txtResult.text = "초기화";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
