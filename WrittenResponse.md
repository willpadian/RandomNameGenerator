# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to get a random name for the purpose of entertainment.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that my program can randomly generate names.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program takes the input of an integer number representing the number of random names that the user would like to be generated. Then, my program outputs the randomly generated names based on the input into the terminal.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> testLastNames;
            testLastNames = new List<string>();
            testLastNames.Add("Bjerre");
            testLastNames.Add("Wren");
            testLastNames.Add("Padian");
            testLastNames.Add("Tall");
            testLastNames.Add("the Baller");
            testLastNames.Add("Jackson");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
int secondIndex = generator.Next(0, lastNames.Count);
string randomName = firstNames[firstIndex] + " " + lastNames[secondIndex];
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "testLastNames".

### 3b iv.

Describes what the data contained in the list represents in your program

This list represents all possible last names that can be generated.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list contains 6 last names. This could be written with 6 if / else if statements. This list manages complexity by allowing the random index to select the random last name instead of using an if statement.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static string GenerateRandomName(List<string> firstNames, List<string> lastNames)
        {
            Random generator = new Random();
            int firstIndex = generator.Next(0, firstNames.Count);
            int secondIndex = generator.Next(0, lastNames.Count);
            string randomName = firstNames[firstIndex] + " " + lastNames[secondIndex];
            return randomName;
        }

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
RandomName = GenerateRandomName(testFirstNames, testLastNames);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a list of first and last names, generate a random name using one entry from each list. This is the main functionality of the program.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

The variable generateRandomName uses selection in order to select which name to randomly generate.

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: GenerateRandomName(null);

Second call: GenerateRandomName(testFirstNames, testLastNames);

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This tests that the method fails when the input is null by throwing an exception.

Condition(s) tested by the second call:

This tests that the method runs when the input is not null.

### 3d iii.

The result is an exception is thrown

Result of the second call:

The result is a random name being generated.