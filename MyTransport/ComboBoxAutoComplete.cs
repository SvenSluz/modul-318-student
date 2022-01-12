using MyTransport.Station;

namespace MyTransport;

public static class ComboBoxAutoComplete
{
    public static void HandleAutoComplete(ComboBox comboBox, List<string>? suggestedStationsList)
    {
        comboBox.DroppedDown = true;
        ComboBoxAutoComplete.ClearComboBox(comboBox);
        ComboBoxAutoComplete.ResetCombobox(comboBox);
        comboBox.Items.AddRange(suggestedStationsList.Where(s => !string.IsNullOrEmpty(s)).ToArray());
    }
    public static void ResetCombobox(ComboBox comboBox)
    {
        comboBox.SelectionLength = 0;
        Cursor.Current = Cursors.Default;
    }

    public static void ClearComboBox(ComboBox comboBox)
    {
        while (comboBox.Items.Count != 0)
        {
            comboBox.Items.RemoveAt(0);
        }
    }
}