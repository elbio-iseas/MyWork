class Person:
    def __init__(self, fname, lname):
        self.firstname = fname
        self.lastname = lname

    def printname(self):
        print(self.firstname, self.lastname)

# use the person to create an object and
# then execute the printname method:

x = Person("Jack", "Reacher")
y = Person("John", "Wick")
z = Person("Mr.", "McCall")
x.printname()
y.printname()
z.printname()