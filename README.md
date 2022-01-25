# RandomNameGenerator

## Description

This project entails the choosing of how many random names you want. After this step, the program will randomly generate a list of first and middle names that are designed to be used to call your friends. These names are supposed to become funny nicknames that will allow friends to bond with each other even better.

## Overview

The purpose of my random name generator is to create silly nicknames that friends can call each other by randomizing a list of names and selecting a first and middle name. The program allows the user to choose the number of possible nicknames that they want by inputting a number. After, the program will list the possible nicknames.

## High Level Design

At a high level the game works as follows:

1.Prompts the user to enter the number of random names to generate
2.Loads a list of possible first names
3.Loads a list of possible middle names
4.Randomly selects a first and middle name
5.Writes the randomly generated name to the console
6.If more names need to be generated, go to step 5
7.Otherwise, the program exits

### Flowchart

## Methods

int GetPositiveInt(string prompt);

This int method is used in order to differentiate between positive and negative numbers. If the number is negative, then there will be an error output by the program. This is because the program needs to be prompted by a positive number in order to know the amount of names that the user wants to generate.

string GenerateRandomName(List<string> firstNames, List<string> midNames);

This string is what actually randomly chooses the names that are necessary for the program to output in order for the program to be running properly. The string is what specifically randomized the output names for the program.

firstNames[firstIndex] + " " + midNames[midIndex];

This method is used to place the two randomized names that were generated together in order to get the complete output that the user asked for in this name generator project.