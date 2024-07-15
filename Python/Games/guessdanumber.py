import random


def main():
  wannaplay = "y"
  while wannaplay.lower() == "y":
    print("Guess the number from 1 to 10 Game")
    num2guess = random.randint(1, 10)
    guessnum = 0
    tries = 1
    while guessnum != num2guess and tries <= 10:
      guessnum = int(input("Type the your guessed number [1-10] and press [Enter]: "))
      tries += 1
      if guessnum == num2guess:
        print("Congratulations!!! you guessed the number in", tries - 1, "attempt/s.")
        tries = 11
    print("")
    wannaplay = input("Play again? [y/n] ")


if __name__ == "__main__":
  main()
