def main():
    answer = "y"
    while answer.lower() == "y":
        fname = input("Enter your name: ")
        print(fname)

        answer=input("Do you want to continue? y/n ")
    print("Goodbye!")

if __name__ == "__main__":
    main()

    
