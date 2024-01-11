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
        // тут просто берем значения из статического класса и передаем в текст.
        string staticValue = ValueTextInCanvas._valueInText;
        _textInCanvas.text = staticValue;

        // здесь по тэгу ищем объект и берем у него нужный компонент и его значения выводим.
        GameObject gameObject = GameObject.FindGameObjectWithTag("FoundText");
        _lookingForText.text = gameObject.GetComponent<LookingForText>()._lookingValue.ToString();
        
        // В примере выше мы могли бы и напрямую добавить в поле "_lookingForTextClass"
        // объект, содержащий нужный компонент и взять значения напрямую
        // _lookingForText.text = _lookingForTextClass._lookingValue.ToString();
    }
    private void Update()
    {
        TimerSetup();
    }
    private void TimerSetup()
    {
        // тут мы берем значения из класса наследника данного объекта и выводим на экран.
        _timeValue = GetComponentInChildren<TimerInCanvas>()._time;
        _timerInCanvas.text = _timeValue.ToString();
    }
    // также можно использовать Zenject и инжектить объекты с нужными компонентами.
    // либо взять LeoEcs и через системы также добавить взаимодействие между классами.
}
