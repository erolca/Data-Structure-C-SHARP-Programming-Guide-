class MainClass
{
    static void Main()
    {

        string[] languages = new string[4] { "C#", "COBOL", "Java", "C++" };

        string language = languages[3];
        languages[3] = languages[2];
        languages[2] = language;

    }
}