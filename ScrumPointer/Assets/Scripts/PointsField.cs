using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsField : MonoBehaviour {

	[SerializeField] private Button _lessButton;
	[SerializeField] private Button _moreButton;

	[SerializeField] private Text _amount;

	[HideInInspector]public float value;
    
	void Start () {
		value = 0f;
		UpdateText();
	}

	private void OnEnable()
	{
		_lessButton.onClick.AddListener(DecreaseValue);
		_moreButton.onClick.AddListener(IncreaseValue);
	}

	private void OnDisable()
    {
		_lessButton.onClick.RemoveListener(DecreaseValue);
		_moreButton.onClick.RemoveListener(IncreaseValue);
    }

	void IncreaseValue(){
		if(value == 0f)
		{
			value = 0.5f;
		}

		else if (value == 0.5f)
        {
            value = 1;
        }

		else if (value == 1f)
        {
            value = 2;
        }

		else if (value == 2f)
        {
            value = 3;
        }
        
		else if (value == 3f)
        {
            value = 5;
        }

		else if (value == 5f)
        {
            value = 8;
        }

		else if (value == 8f)
        {
            value = 13;
        }

		else if (value == 13f)
        {
			return;
        }

		UpdateText();
	}

	void DecreaseValue()
    {
        if (value == 0f)
        {
			return;
        }

        else if (value == 0.5f)
        {
            value = 0;
        }

        else if (value == 1f)
        {
            value = 0.5f;
        }

        else if (value == 2f)
        {
            value = 1;
        }

        else if (value == 3f)
        {
            value = 2;
        }

        else if (value == 5f)
        {
            value = 3;
        }

        else if (value == 8f)
        {
            value = 5;
        }

        else if (value == 13f)
        {
			value = 8;
        }

        UpdateText();
    }

	void UpdateText(){
		_amount.text = value.ToString();
		PointsManager.Instance.UpdateTotal();
	}
}
