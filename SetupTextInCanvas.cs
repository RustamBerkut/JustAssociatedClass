using UnityEngine;
using UnityEngine.UI;

public class SetupTextInCanvas : MonoBehaviour
{
    [SerializeField] private Text _textInCanvas;
    [SerializeField] private Text _timerInCanvas;
    [SerializeField] private Text _lookingForText;
    [SerializeField] private LookingForText _lookingForTextClass;
    

    private float _timeValue;

    private void Start()
    {
        // ��� ������ ����� �������� �� ������������ ������ � �������� � �����.
        string staticValue = ValueTextInCanvas._valueInText;
        _textInCanvas.text = staticValue;

        // ����� �� ���� ���� ������ � ����� � ���� ������ ��������� � ��� �������� �������.
        GameObject gameObject = GameObject.FindGameObjectWithTag("FoundText");
        _lookingForText.text = gameObject.GetComponent<LookingForText>()._lookingValue.ToString();
        
        // � ������� ���� �� ����� �� � �������� �������� � ���� "_lookingForTextClass"
        // ������, ���������� ������ ��������� � ����� �������� ��������
        // _lookingForText.text = _lookingForTextClass._lookingValue.ToString();
    }
    private void Update()
    {
        TimerSetup();
    }
    private void TimerSetup()
    {
        // ��� �� ����� �������� �� ������ ���������� ������� ������� � ������� �� �����.
        _timeValue = GetComponentInChildren<TimerInCanvas>()._time;
        _timerInCanvas.text = _timeValue.ToString();
    }
    // ����� ����� ������������ Zenject � ��������� ������� � ������� ������������.
    // ���� ����� LeoEcs � ����� ������� ����� �������� �������������� ����� ��������.
}
