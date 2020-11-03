using System;

namespace Object4
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            player.CharacterName = "Tie Fighter";
            player.Strength = 12;
            Console.WriteLine($"{player.CharacterName} {player.Strength}");

            Character opponent = new Character();
            opponent.CharacterName = "Stormtrooper";
            opponent.Strength = 9;
            Console.WriteLine($"{opponent.CharacterName} {opponent.Strength}");

            Battle battleParticipants = new Battle();
            battleParticipants.BattleStart(player, opponent);
            Console.WriteLine($"{battleParticipants.PlayerObject.CharacterName} {battleParticipants.PlayerObject.Strength}");
            Console.WriteLine($"{battleParticipants.OpponentObject.CharacterName} {battleParticipants.OpponentObject.Strength}");
        }
    }

    class Character
    {
        public string CharacterName { get; set; }

        public int Strength { get; set; }
    }
    class Battle
    {
        public Character PlayerObject;
        public Character OpponentObject;

        public void BattleStart(Character playerParameter, Character opponentParameter)
        {
            PlayerObject = playerParameter;
            OpponentObject = opponentParameter;
        }
    }
}
