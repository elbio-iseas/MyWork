f = open('users.txt')
users = f.readlines()
n = len(users)
print(users)
if n > 0:
  for i in users:
    print(i)
f.close()
f = open('users.txt', 'a')
line = 'Liset\n'
f.write(line)
f.close()
users.append('Liset\n')
if n > 0:
  for i in users:
    print(i)
users.sort()
if n > 0:
  for i in users:
    print(i)
