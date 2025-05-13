using UnityEngine;
using UnityEngine.UIElements;

public class GameUIHandler : MonoBehaviour
{
    //UI elements
    private UIDocument _uiDoc;
    private Label _boxLabel;
    private VisualElement _boxBarMask;
    //box related
    private int _maxBoxes = 5;
    private int _collectedBoxes = 0;
    
    void Start()
    {
        //get a reference to the UI Document component on this game object
        _uiDoc = GetComponent<UIDocument>();
        //get a reference to the text label in the UI Document
        _boxLabel = _uiDoc.rootVisualElement.Q<Label>("BoxLabel");
        //get a reference to the mask of the fill bar in the UI Document
        _boxBarMask = _uiDoc.rootVisualElement.Q<VisualElement>("BoxBarMask");
    }

    void Update()
    {
        //calculate the ratio of boxes collected out of the total amount available
        float boxBarRatio = (float)_collectedBoxes / _maxBoxes;
        //calculate the percentage of boxes collected and map it to the scale of the actual mask
        float boxBarPercent = Mathf.Lerp(15, 100, boxBarRatio);
        //update the text label
        _boxLabel.text = $"{_collectedBoxes}/{_maxBoxes}";
        //update the width of the mask
        _boxBarMask.style.width = Length.Percent(boxBarPercent);
    }
    
    //public function for increasing the amount of collected boxes
    public void IncreaseBoxes()
    {
        _collectedBoxes++;
    }
}
