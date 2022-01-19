
---

<details>
<summary>Table of Contents</summary>

1. [`Technical specifications`](#1-Technical-specifications)
2. [`Functional specifications`](#2-Functional-specifications)
</details>

---

# 1. Technical specifications:

 
### Team :

 - [Vinette Karine](https://github.com/KarineVinette) (Team Manager)
 - [Desvaux Brendon](https://github.com/BrendonDesvaux) (Tech Lead)
 - [Bobis Alexandre](https://github.com/AlexandreBobis)
 - [MIDA Nicolas](https://github.com/Nicolas-Mida)
 - [Archimbaud Malo](https://github.com/Malo-Archimbaud)
 - [Lorut-Gauriat Martin](https://github.com/MartinLorutGauriat)

### Reviewers :

 - [Robert Pickering](https://github.com/robertpi)
 - [Franck Jeannin](https://github.com/frje)

 

### Context :

The context of the project is to create a library that could be used by a developer/artist to create, modify, listen to and save sounds used for musical purposes as well as do the same to an entire list of said sounds.  

### Language :

[**F#**](https://fsharp.org/)

### Library :

 - [**SFML**](https://www.sfml-dev.org/index.php)  
  
 - [**XPlot**](https://fslab.org/XPlot)

### Dotnet version :

dotnet [5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

## Organisation
![Organigram](https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/Orga.png?raw=true)

## Risks

-   Multiplatform sound playing

## Device Compatibility :

_MacOS_  
_Windows_

### Download at :

[**Github**](https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C)

## Terminology :

### API :

```
An application programming interface (API) is a connection between computers or between computer programs. It is a type of software interface, offering a service to other pieces of software

```

#### [Synthesis / Synthesizer](https://en.wikipedia.org/wiki/Synthesizer)

### Octave :

```
An octave is the interval between one musical pitch and another with double its frequency. 

```

## In Scope :


|           Scope          |
|--------------------------|
| Library                  |
| Read/Write wav/mp3 files |
| Playing Sounds           |
| Modifying Sound          |
| Applying filters         |
| Creating musical notes   |
| Creating simple melodies |
| Console application      |



## Out of scope

...

## Test Plan

We are actually working with Test-Driven Development (TDD) so we can assure the code we produce is verified and working.

## User Access

The client will have access to an API containing all the necessary functions to use the functionalities of a synthesizer and a document "How to use" to explain the functionalities and how to use them.

# 2. Functional specifications:

## Synthetizer and how it works?

A **synthesizer** is an electronic musical instrument that generates audio signals. Synthesizers typically create sounds by generating waveforms. These waves may be altered by components such as filters that cut or boost frequencies, envelopes that control articulation or how notes begin and end, and low-frequency oscillators, which modulate parameters such as pitch or volume. Synthesizers are typically played with keyboards or controlled by sequencers, software or other instruments, and can be synchronized to other equipment via MIDI.

For our project, we are in the case of Software synthesizers.

## Project Target

Everyone who wants to play with sound synthesis, create music or sounds.

## Use case :
![Use Case](https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/UseCase.png?raw=true)

