class Car:
  def __init__(self, year, make, model, color):
    self.year = year
    self.make = make
    self.model = model
    self.color = color

  def drive(self):
    print("This car is driving")

  def stop(self):
    print("This car stopped")
