def selectionmethod(array):
    for llenar in range(len(array)-1,0,-1):
        mayor = 0;
        for posicion in range(1, llenar+1):
            if array[posicion]>array[mayor]:
                mayor = posicion
        temp = array[llenar]
        array[llenar] = array[mayor]
        array[mayor] = temp

array = [20, 10, 30, 15, 40, 25]
selectionmethod(array)
print(array)

