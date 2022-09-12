//While loop

bool isFound = false;
int value = 0;
while (isFound != true) //check whether or not run code inside its block
{
    if(value == 99)
    {
        isFound = true;
    }
    value = value + 3;
    Console.WriteLine(value);
}