# Challenge: The Prototype

Mylara, the captain of the Guard of Consolas, has approached you with the beginnings of a plan to hunt down The Uncoded One's airship. "If we're going to be able to track this thing down," she says, "we need you to make us a program that can help us home in on a location." She lays out a plan for a program to help with the hunt. One user, representing the airship pilot, picks a number between 0 and 100. Another user, the hunter, will then attempt to guess the number. The program will tell the hunter that they guessed correctly or that the number was too high or low. The program repeats until the hunter guesses the number correctly. Mylara claims, "If we can build this program, we can use what we learn to build a better version to hunt down the Uncoded One's airship."

## Sample Program 

    user 1, enter a number between 0 and 100: *27*

After entering this number, the program should clear the screen and continue like this:

```markdown
User 2, guess the number.
    What is your next guess: *50*
50 is too high

What us your nexr guess: *25*
25 is too low

What is your next guess: *27*
You guessed the number!
```

## Objectives

1. Build a program that will allow a user, the pilot, to enter a number.
2. If the number is above 100 or less than 0, keep asking.
3. Clear the screen once the program has collected a good number.
4. Indicate whether the user guessed too high, too low, or guessed right.
5. Loop intil they get it right, then end the program.
