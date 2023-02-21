matriz = []
valor = 0
x = 2
y = 4
for i in range (x):
    matriz.append([])
    for j in range (y):
        valor = valor + 10
        matriz[i].append(valor)

print("\tImprimir matriz\n")
for i in matriz:
    print("|", end = ' ')
    for j in i:
        print(" ", format(j), end=' ')
    print(" |\n")
print("\n")