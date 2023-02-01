using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionUnitManager : MonoBehaviour
{
    private List<SelectionUnit> selectionUnits = new List<SelectionUnit>();

    public void AddSelectionUnit(SelectionUnit unitToAdd)
    {
        selectionUnits.Add(unitToAdd);
    }

    public void DeselectAllUnits()
    {
        foreach (SelectionUnit selectionUnit in selectionUnits)
        {
            selectionUnit.DeselectUnit();
        }
    }
}
