namespace WorkingWithTex;

public static class StringUtility
{
    public static string Summarize(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
            return text;

        var words = text.Split(' ');
        var summaryWords = new List<string>();
        var totalCharLength = 0;

        foreach (var word in words)
        {
            summaryWords.Add(word);

            totalCharLength += word.Length + 1;
            if (totalCharLength > maxLength)
                break;
        }

        var summary = string.Join(" ", summaryWords) + "...";
        return summary;
    }
}