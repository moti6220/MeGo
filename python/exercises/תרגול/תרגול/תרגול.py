# for i in range (1,11):
#     for c in range (1,11):
  




def brothers(num1,num2):
    num1 = str(num1)
    num2 = str(num2)
    if(num1[0]==num2[0] and num1[len(num1-1)]==num2[len(num2-1)]):
        return True
    return False
print(brothers(123,13))
print(brothers(123,14))





