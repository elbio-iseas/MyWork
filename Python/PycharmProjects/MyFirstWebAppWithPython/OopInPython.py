from Car import Car

car_1 = Car(2018, "Toyota", "Tacoma", "Red")
car_2 = Car(2011, "Lexus", "RX350", "Gray")
car_3 = Car(1995, "Dodge", "Avenger", "Red")

print("Year : " + str(car_1.year))
print("Make : " + car_1.make)
print("Model: " + car_1.model)
print("Color: " + car_1.color)

car_1.drive()
car_1.stop()

print("Year : " + str(car_2.year))
print("Make : " + car_2.make)
print("Model: " + car_2.model)
print("Color: " + car_2.color)

car_2.drive()
car_2.stop()

print("Year : " + str(car_3.year))
print("Make : " + car_3.make)
print("Model: " + car_3.model)
print("Color: " + car_3.color)

car_3.drive()
car_3.stop()
