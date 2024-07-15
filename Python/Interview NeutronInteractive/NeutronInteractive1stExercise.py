def caught_speeding(speed, is_birthday):
	
	bonus = 5 if is_birthday else 0
	if speed <= (60 + bonus):
		value = 0
	elif speed > (60 + bonus) and speed <= (80 + bonus):
		value = 1
	elif speed >= (81 + bonus):
		value = 2
	
	return value
	
print(caught_speeding(60, False))
print(caught_speeding(65, False))
print(caught_speeding(65, True))

