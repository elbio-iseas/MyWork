mylist = ["a", "b", "a", "c", "c"]
mylist2 = ["a", "b", "a", "c", "c", "d", "e", "d", "f", "f"]
mylist = list(dict.fromkeys(mylist))
print(mylist)


def no_duplicates(L):
  return list(set(L))


list3 = no_duplicates(mylist2)
print(list3)
list3.sort()
print(list3)


