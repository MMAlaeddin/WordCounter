# _Word Counter_

#### _An app that counts specific words in a sentence based off of user input_

#### By _**Mariam Alaeddin**_

## Description

This is an app that allows the user to input a single word and a sentence.  Once submitted, the console will count how many times the input word is repeated in the given sentence.

## BDD
* Behavior: Return a word input
    * Input: "test"
    * Output: "test"
* Behavior: Will give error and return to main if input contains numbers or special charecters
    * Input: "5test"
    * Output: "Error" "Please Enter a word."
* Behavior: Return a sentence with word
    * Input: "This is a sentence test"
    * Output: "This is a sentence test"
* Behavior: Counts input word in input sentence
    * Input: inputWord "test" , inputSent "This is a sentence test"
    * Output: 1

## Setup/Installation Requirements

* '$ cd desktop' in your terminal
* '$ git clone' [THIS REPO](https://github.com/MMAlaeddin/WordCounter)
* '$ cd (file name)'
* '$ cd WordCounter'
* '$ dotnet restore'
* '$ cd ..' '$ cd WordCounter.Tests'
* '$ dotnet restore'
* '$ code .'

## Known Bugs

No known bugs

## Support and contact details

maralaeddin@gmail.com

## Technologies Used

C# | .NET

### License

* MIT License 

Copyright (c) 2020 **Mariam Alaeddin**