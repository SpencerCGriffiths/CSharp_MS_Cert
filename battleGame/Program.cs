// Role playing game battle challenge

// In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys". Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score. Once either character's health reaches zero, they lose the game.
// In this challenge, we'll boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, they'll generate a random value which will be subtracted from the monster's health. If the monster's health is greater than zero, they'll take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle will resume.

// Code challenge - write code to implement the game rules
// Here are the rules for the battle game that you need to implement in your code project:

// You must use either the do-while statement or the while statement as an outer game loop.
// The hero and the monster will start with 10 health points.
// All attacks will be a value between 1 and 10.
// The hero will attack first.
// Print the amount of health the monster lost and their remaining health.
// If the monster's health is greater than 0, it can attack the hero.
// Print the amount of health the hero lost and their remaining health.
// Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
// Print the winner.

int heroHealth = 10;
int monsterHealth = 10;
Random attack = new Random();
string turn = "hero";

do 
{int damage = attack.Next(0,11);
if (turn == "hero") { 
    monsterHealth -= damage;
    string result = $"Hero attacked with {damage} damage";
    result += monsterHealth > 0 ? $" \n\t The monster has {monsterHealth} health remaining. \n\t It's the monster's turn." : " \n\t The monster is dead and the game is over.";
    Console.WriteLine(result);
    turn = "monster";
} else if (turn == "monster") { 
    heroHealth -= damage;
    string result = $"Monster attacked with {damage} damage";
    result += heroHealth > 0 ? $" \n\t The Hero has {heroHealth} health remaining. \n\t It's the Hero's turn." : " \n\t The Hero is dead and the game is over.";
    Console.WriteLine(result);
    turn = "hero";
} 
}while (monsterHealth > 0 && heroHealth > 0);