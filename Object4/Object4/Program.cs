using System;

namespace Object4
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            player.CharacterName = "Tie Fighter Main Method";
            player.Strength = 3;
            Console.WriteLine($"{player.CharacterName} {player.Strength}");

            Character opponent = new Character();
            opponent.CharacterName = "Stormtrooper Main Method";
            opponent.Strength = 6;
            Console.WriteLine($"{opponent.CharacterName} {opponent.Strength}");

            Battle battleParticipants = new Battle();
            battleParticipants.BattleStart(player, opponent);
            Console.WriteLine($"{battleParticipants.PlayerObject.CharacterName} {battleParticipants.PlayerObject.Strength}");
            Console.WriteLine($"{battleParticipants.OpponentObject.CharacterName} {battleParticipants.OpponentObject.Strength}");

            Round roundParticipants = new Round();
            roundParticipants.Fight(player, opponent);
            Console.WriteLine($"{roundParticipants.PlayerObject.CharacterName} {roundParticipants.PlayerObject.Strength}");
            Console.WriteLine($"{roundParticipants.OpponentObject.CharacterName} {roundParticipants.OpponentObject.Strength}");
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

            PlayerObject.CharacterName = "Tie Fighter Battle Class";
            PlayerObject.Strength = 9;
            OpponentObject.CharacterName = "Stormtrooper Battle Class";
            OpponentObject.Strength = 12;
        }
    }

    class Round
    {
        public Character PlayerObject;
        public Character OpponentObject;

        public void Fight(Character playerParameter, Character opponentParameter)
        {
            PlayerObject = playerParameter;
            OpponentObject = opponentParameter;

            PlayerObject.CharacterName = "Tie Fighter Round Class";
            PlayerObject.Strength = 16;
            OpponentObject.CharacterName = "Stormtrooper Round Class";
            OpponentObject.Strength = 24;

            Console.WriteLine($"{PlayerObject.CharacterName} {PlayerObject.Strength}");
            Console.WriteLine($"{OpponentObject.CharacterName} {OpponentObject.Strength}");
        }
    }
}
