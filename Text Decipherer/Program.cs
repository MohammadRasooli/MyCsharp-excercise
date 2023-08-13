string encryptedMessage = "Whiskey Hotel Four Tango Dash Aplpha Romeo Three " +
            "Dash Yankee Oscar Uniform Dash Sierra One Novamber " +
            "Kilo India Novamber Golf Dash Four Bravo Zero Uniform Seven";


string[] split = encryptedMessage.Split(" ");

Dictionary<string, string> replacements = new Dictionary<string, string>
        {
            { "Zero", "0" },
            { "One", "1" },
            { "Two", "2" },
            { "Three", "3" },
            { "Four", "4" },
            { "Five", "5" },
            { "Six", "6" },
            { "Seven", "7"},
            { "Eight", "8" },
            { "Nine", "9" },
            { "Dash", "-" },
        };

for (int i = 0; i < split.Length; i++)
{
    if (replacements.ContainsKey(split[i]))
    {
        split[i] = replacements[split[i]];
    }
    string letter = split[i];
    Console.Write(letter[0]);
}