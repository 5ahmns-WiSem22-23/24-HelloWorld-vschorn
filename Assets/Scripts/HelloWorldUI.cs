using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class HelloWorldUI : MonoBehaviour
{
    [SerializeField]
    private InputField inputField;
    [SerializeField]
    private TextMeshProUGUI text;

    private void Awake()
    {
        text.gameObject.SetActive(false);
    }

    public void ShowText()
    {
        text.text = inputField.text;
        if (!text.gameObject.activeSelf) text.gameObject.SetActive(true);
    }
}
