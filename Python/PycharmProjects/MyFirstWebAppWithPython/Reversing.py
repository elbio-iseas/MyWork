def reverse(t):
  return t[:: -1]


txt = reverse("En un lugar de la Mancha")
print(txt)

txt = "Hello World!"[:: -1]
print(txt)
