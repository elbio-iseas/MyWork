f = open('users.txt')
f
users = f.readlines()
f.close()
f = open('users.txt','w')
n=len(users)
print(users)
users.sort()
if n > 0 :
   for i in users:
       f.write(i)
f.close()
if n > 0 :
   for i in users:
       print(i)
