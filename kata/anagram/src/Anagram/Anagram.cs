namespace Anagram
{
    // public class Anagram
    // {
    //    public Anagram() {}

    //    public List<string> Of(string word)
    //    {
    //         return new List<string>("AB", "BA");
    //    }
    // }


    public class Anagram
    {
        public List<string> Of(string s)
        {
            if (s.Length <= 1)
                return new List<string> { s };
            var anagrams = new List<string>();
            for (var i = 0; i < s.Length; i++)
            {
                var droppedCharacter = s.Substring(i, 1);
                var anagramsOfRest = new Anagram().Of(DropCharacter(s, i));
                foreach (var anagramOfRest in anagramsOfRest)
                    anagrams.Add(droppedCharacter + anagramOfRest);
            }
            return anagrams;
        }

        private string DropCharacter(string s, int index)
        {
            var response = s.Substring(0, index) + s.Substring(index + 1, s.Length - (index + 1));
            Console.WriteLine(response);
            return response;
        }
    }
}
