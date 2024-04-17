// # Guided Project: 

// Your developing an application for Contoso petting zoo for school visits

// There are 18 species of animal. Visiting studetns are assigned to groups. each group has a set of animals assigned to them. After visiting their set the students rotte groups until they've seen all the animals. 

// By default the students are in 6 groups. Some classes have more or less students so the number of groups must be adjusted accordingly. The anumals should be randomly assigned to each group. 

// There are currently three visiting schools

// School A has six visiting groups (the default number)
// School B has three visiting groups
// School C has two visiting groups
// For each visiting school, perform the following tasks

// Randomize the animals
// Assign the animals to the correct number of groups
// Print the school name
// Print the animal groups

using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

string schoolName = "SchoolA";

int groups = 3;

PlanSchoolVisit(schoolName, pettingZoo, groups);

void PlanSchoolVisit(string schoolName, string[] pettingZoo, int groups = 6) 
{ 
AnimalsRandom();
string[,] result = AssignGroup();
PrintGroup(result, schoolName); 

void AnimalsRandom()
{ 
    // Fisher Yates Shuffle!!! Select an item in the array and swap it with an item between the current index and the end! 

    Random random = new Random();
    
    for(int i = 0; i < pettingZoo.Length; i++) 
    { 
        int indexSwap = random.Next(i, pettingZoo.Length);
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[indexSwap]; 
        pettingZoo[indexSwap] = temp; 
    };
}

string[,] AssignGroup(int groups = 6)
{ 
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int rows = result.GetLength(0); 
    int collums = result.GetLength(1);
    int petIndex = 0; 

    for (int r = 0; r < rows; r++)
    {
        result[r,0] += $"Group {r + 1}";
        for (int c = 1; c < collums; c++)
        {
            result[r,c] += pettingZoo[petIndex];
            petIndex++;
        }
    }
    return result;
}

string PrintGroup(string[,] groups, string school)
{ 
    string result = school + "\n"; 
for (int i = 0; i < groups.GetLength(0); i++)
{   
    string toAppend = groups[i,0] + ": ";
    for (int k = 1; k < groups.GetLength(1); k++)
    {
        toAppend += groups[i,k] + " ";
    }
    result += toAppend + "\n";
}
    Console.WriteLine($"{result}");
    return result;
}


}



// set methods: 
// AnimalsRandom();
// string[,] group = AssignGroup();
// PrintGroup(group);
