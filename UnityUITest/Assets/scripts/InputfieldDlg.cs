using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputfieldDlg : MonoBehaviour
{
    // Start is called before the first frame update


    public Text m_ResultText = null;
    public InputField m_InputName = null;
    public Button button = null;
    void Start()
    {
        button.onClick.AddListener(OnClicked_start);
    }
    public void OnClicked_start()
    {
        string sValue = m_InputName.text;
        //if(sValue==null)
        //{
        //    m_ResultText.text = "입력값이 없습니다";
        //}
        //else
            m_ResultText.text = sValue;

        if(m_InputName.text=="")
        {
            m_ResultText.text = "입력값이 없습니다";
            return;
        }

    }
    public void OnClicked_clear()
    {
        m_ResultText.text = "clear";
        m_InputName.text = "";
    }
    // Update is called once per frame

    void Update()
    {
        
    }
}
