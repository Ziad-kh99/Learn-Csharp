# Exercise: Roll Dice Game.
### In this exercise you will practic:
- Write code that evaluates conditions using if, else, and else if statements.
- Build Boolean expressions to evaluate a condition.
- Combine Boolean expressions using logical operators.
- Nest code blocks within other code blocks.


## Roll Dice Game (version 1):
- You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. 
  If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, 
  you'll display a losing message to the user.
    - If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
    - If all three dice you roll result in the same value, you get six bonus points for rolling triples.
    - If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.

## Roll Dice Game (version 2):
- To make the game more fun, you can change the game from "win-or-lose" to awarding fictitious prizes for each score. 
  You can offer four prizes. However, the player should win only one prize:
    - If the player scores greater or equal to 16, they'll win a new car.
    - If the player scores greater or equal to 10, they'll win a new laptop.
    - If the player scores exactly 7, they'll win a trip.
    - Otherwise, the player wins a kitten.