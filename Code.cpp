array[5, 98, 6, 35, 41, 26];
size = 6;
index = 0;
max = numbers[0];
while(index < size):
    if(numbers[index] > max):
        max = numbers[index]
        index = index +1 
    index = index + 1
print(max[index]);