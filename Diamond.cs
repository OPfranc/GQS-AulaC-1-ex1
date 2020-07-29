using System.Collections.Generic;

namespace ex1
{
    public class Diamond
    {
        private char Letter { get; set; }
        private const int INITIAL_INDEX = 65;
        private bool ValidadeData(char letter)
        {
            if (letter == 'Ç' || letter == 'Ñ' || letter == 'ç' || letter == 'ñ'){
                return false;
            }

            return char.IsLetter(letter);
        }
        public string[] CreateDiamond(char letter)
        {
            Letter = char.ToUpper(letter);

            if (!ValidadeData(letter))
            {

                string[] error = { "Caracter invalido!" };
                return error;
            }

            List<char> charList = new List<char>();
            List<string> strList = new List<string>();

            for (var Char = 'A'; Char <= Letter; Char++)
            {
                charList.Add(Char);
            }

            foreach (var character in charList)
            {
                var innerSpace = (int)character - INITIAL_INDEX;
                var outerSpace = charList.Count - innerSpace;
                strList.Add(DiamondLineCreator(character, innerSpace, outerSpace));
            }
            var reverseStrList = new List<string>(strList);
            reverseStrList.Reverse();
            reverseStrList.RemoveAt(0);

            string[] diamond = new string[(charList.Count * 2) - 1];

            strList.CopyTo(diamond);
            reverseStrList.CopyTo(diamond, strList.Count);

            return diamond;
        }

        private string DiamondLineCreator(char letter, int innerSpace, int outerSpace)
        {

            string newString;

            if (letter == 'A')
            {
                var spacingString = new string(' ', outerSpace);
                newString = string.Concat(
                                    spacingString,
                                    letter.ToString(),
                                    ' ',
                                    spacingString);
            }
            else
            {
                var spacingString = new string(' ', outerSpace);
                var innerSpacingString = new string(' ', innerSpace * 2);
                newString = string.Concat(
                                    spacingString,
                                    letter.ToString(),
                                    innerSpacingString,
                                    letter.ToString(),
                                    spacingString);
            }
            return newString;
        }
    }
}