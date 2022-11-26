int integers = int.Parse(Console.ReadLine());
int integersmin;
int integersmax;
if(integers > 0)
    {
        integersmin = -integers;
        integersmax = integers;
    }
else
    {
       integersmin = integers;
       integersmax = -integers; 
    }

while(integersmin <= integersmax)
    {
        Console.WriteLine(integersmin);
        integersmin += 1;
    }