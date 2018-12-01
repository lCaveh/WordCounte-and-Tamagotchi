# _Word Counter_

#### _A C# program for Epicodus, 11.30.2018_

#### By _**Kaveh Saleminejad**_

## Description
_This project contains 2 part. The first one is WordCounter and the second one is Tamagotchi game_
_WordCounter gets a word and a sentence from user. Then it will count how many times the inputed word appears in the sentence. It just check for full word matches only, and if part of a word in sentence matches with the inputed word it just will ignore it._
_Tamagotchi game will create a virtual pet with 3 stat:energy,hunger, and attention. This stats will start at 50 and will decrease by 1 every 3 second. The user can increase them by using some items in inventory. If every stat comes below 30 the image of pet will be change depends on the stat. Finally, if any stat reach 0 the pet will die.

## Behavior-Driven Development

* _First make sure the input word and sentence are valid_
_For example: "" is not valid for both and "Hey you" is not valid for word_
* _Next change both the input word and sentence to lowercase characters_
_For example: "I am happy" should be change to  ["i am happy"]_
* _Then chunk the sentence into an array of words and get rid of all characters except alphabets and numbers_
_For example: "i am happy." should be create ["i","am","happy"]_
* _After that check the input word with all words in the sentence to find the duplicates_
_For example: the word "found" appears once in the ["i", "found", "a", "solution"]_

## Specifications



## Setup/Installation Requirements

* _Clone this repository_
* _Install Mono and .NET Framework_   
* _To run the program, first navigate to the location of the Music file then run dotnet restore, dotnet build, and dotnet run._
* _When program is running open a web browser and go to localhost:5000 to view program._


## Support and contact details

_Contact Kaveh Saleminejad - lcaveh@gmail.com._

## Technologies Used

* _C#_
* _.NET_
* _MVC_
* _Razor_
* _MS Test_


### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Kaveh Saleminejad_**
