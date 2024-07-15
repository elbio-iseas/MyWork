def alarm_clock(day, vacation):
    
    ring = "Oops! Something went wrong."
    if vacation:
        if (day > 0) and (day < 6):
            ring = "10:00"
        elif (day == 0) or (day == 6):
            ring = "off"
    else:
        if (day > 0) and (day < 6):
            ring = "7:00"
        elif (day == 0) or (day == 6):
            ring = "10:00"
    
    return ring
    
print(alarm_clock(1, False))
print(alarm_clock(5, False))
print(alarm_clock(0, False))

print(alarm_clock(0, False))
print(alarm_clock(1, False))
print(alarm_clock(2, False))
print(alarm_clock(3, False))
print(alarm_clock(4, False))
print(alarm_clock(5, False))
print(alarm_clock(6, False))

print(alarm_clock(0, True))
print(alarm_clock(1, True))
print(alarm_clock(2, True))
print(alarm_clock(3, True))
print(alarm_clock(4, True))
print(alarm_clock(5, True))
print(alarm_clock(6, True))
print(alarm_clock(7, True))
