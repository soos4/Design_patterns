using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();

            List<Character> characters = new List<Character>
            {
                factory.GetCharacter('A'),
                factory.GetCharacter('B'),
                factory.GetCharacter('B'),
                factory.GetCharacter('Z'),
                factory.GetCharacter('A'),
                factory.GetCharacter('B')
            };

            foreach (Character character in characters)
            {
                character.Display(15);
            }

            foreach (Character character in characters)
            {
                character.Display(8);
            }
        }
    }
}