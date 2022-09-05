using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRadialMenu : MonoBehaviour
{
    private Vector2 _normalisedMousePosition;
    private float _currentAngle;
    private int _selection;
    private int _previousSelection;

    [SerializeField] private int _sections;
    [SerializeField] private GameObject[] _menuItems;
    [SerializeField] private int _angleOffset;
    [SerializeField] private Image _centerOfRadial;

    /*
    private HealthItemRadialHUD _menuItemSelected;
    private HealthItemRadialHUD previousMenuItemSc;

    public HealthItemRadialHUD MenuItemSelected => _menuItemSelected;

    /// <summary>
    /// Update that check mouse position to see which healthItemRadialHud is selected
    /// </summary>
    void Update()
    {
        _normalisedMousePosition = new Vector2(InputManager.Instance.CameraMousePosition.x - Screen.width / 2, InputManager.Instance.CameraMousePosition.y - Screen.height / 2);
        _currentAngle = Mathf.Atan2(_normalisedMousePosition.y, _normalisedMousePosition.x) * Mathf.Rad2Deg;

        _currentAngle = (_currentAngle + 360 + _angleOffset) % 360;

        var subdivisionAngle = 360 / _menuItems.Length;
        _selection = (int)_currentAngle / subdivisionAngle;

        if (_selection != _previousSelection)
        {
            previousMenuItemSc = _menuItems[_previousSelection].GetComponent<HealthItemRadialHUD>();
            previousMenuItemSc.Deselect();
            _previousSelection = _selection;

            _menuItemSelected = _menuItems[_selection].GetComponent<HealthItemRadialHUD>();
            _menuItemSelected.Select();
        }
    }
    */
    public Image CenterOfRadial => _centerOfRadial;
}
