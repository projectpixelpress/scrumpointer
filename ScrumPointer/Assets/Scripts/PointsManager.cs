using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour {

	public static PointsManager Instance;

	[SerializeField] private PointsField _effortField;
	[SerializeField] private PointsField _riskField;
	[SerializeField] private PointsField _complexityField;
	[SerializeField] private PointsField _qaEffortField;
	[SerializeField] private PointsField _buggingOthersField;

	private float _totalValue;
	[SerializeField] private Text _totalText;

	private void Awake()
	{
		if(Instance == null){
			Instance = this;
		}
	}

	public void UpdateTotal(){
		_totalValue = _effortField.value + _riskField.value + _complexityField.value + _qaEffortField.value + _buggingOthersField.value;
		_totalText.text = _totalValue.ToString();
	}
}
