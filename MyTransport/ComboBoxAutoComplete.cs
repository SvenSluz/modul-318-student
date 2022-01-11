namespace MyTransport;

public static class ComboBoxAutoComplete
{
    public static void AutoComplete(string userInput, ComboBox comboBox)
    {
        var stations = new ConnectionProvider().GetSimilarStations(userInput).Result;
        if (stations == null || stations.Count == 0) return;
        foreach (var comboBoxItem in comboBox.Items)
        {
            comboBox.Items.Remove(comboBoxItem);
        }
        comboBox.Items.AddRange(stations.ToArray());
    }
}