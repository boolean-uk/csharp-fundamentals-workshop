# C# Fundamentals Overview

A project to demonstrate most of the skills needed in the Fundamentals part of the C# course.

## User Stories

- I want to put on a music festival called Boolean Fest
- To work out who should be headlining the festival, i want to list bands by the total networth of members
- I want to know a Line Up of Bands that play Boolean Fest
- I want to list all band members that play Boolean Fest
- Band members have skills like singer, lead guitarist, bass, guitarist
- Band members could be known as either their firstname and surname or nickname


| Classes         | Methods/Properties/Constructor                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`Person`|  public Person(string nickname, Skill specialty, int networth)     |        |        |
|`Person`|  public Person(string firstname, string surname, Skill specialty, int networth)     |        |        |
|`Person`|  KnownAs                   | property to return either their first name and surname OR nickname      | string            |
|`Person`|  Specialty | property to return an enum of their specialty, e.g. Singing, Guitarist etc | Specialty Enum             |
|`Person`|  NetWorth | property to return networth | int             |

