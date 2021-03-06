## Technical Specifications ( 26/01/2022 )

<details>
<summary>Table of Contents</summary>
 
- [1. Front Matter](#1-front-matter)
- [2. Introduction](#2-introduction)
    + [2.1: Summary](#21-summary)
    + [2.2 Glossary:](#22-glossary)
    + [2.3: Context](#23-context)
    + [2.4: Requirements](#24-requirements)
    + [2.5: Out Of Scope](#25-out-of-scope)
- [3. Solution](#3-solution)
    + [3.1: Current Solution](#31-current-solution)
    + [3.2: Solution Design:](#32-solution-design)
    + [3.3: Testing:](#33-testing)
- [4. Further Considerations](#4-further-considerations)
    + [4.1: Impact on other teams:](#41-impact-on-other-teams)
    + [4.2: Cost Analysis:](#42-cost-analysis)
    + [4.3: Security consideration](#43-security-consideration)
    + [4.4: Privacy considerations:](#44-privacy-considerations)
    + [4.5: Accessibility considerations:](#45-accessibility-considerations)
    + [4.6: Risks:](#46-risks)
    + [4.7: Support considerations](#47-support-considerations)
- [5. Work](#5-work)
    + [5.1: Work estimates and timelines](#51-work-estimates-and-timelines)
    + [5.2: Prioritization](#52-prioritization)
    + [5.3 Milestones](#53-milestones)
- [6. End Matter](#6-end-matter)
    + [6.1: Related Work](#61-related-work)
    + [6.2: References](#62-references)
    + [6.3: Acknowledgments](#63-acknowledgments)
</details>


## 1. Front Matter
	

 - **Title:** Project Sound Synthesis
 - **Author(s):**  
	 - [Robert Pickering](https://github.com/robertpi)
	 - [Franck Jeannin](https://github.com/frje)
 - **Team:** 
	 - [Vinette Karine](https://github.com/KarineVinette) (Team Manager)
	 - [Desvaux Brendon](https://github.com/BrendonDesvaux) (Tech Lead)
	 - [Bobis Alexandre](https://github.com/AlexandreBobis)
	 - [MIDA Nicolas](https://github.com/Nicolas-Mida)
	 - [Archimbaud Malo](https://github.com/Malo-Archimbaud)
	 - [Lorut-Gauriat Martin](https://github.com/MartinLorutGauriat)
 - **Reviewer(s):**
	 - [Robert Pickering](https://github.com/robertpi)
	 - [Franck Jeannin](https://github.com/frje)
 - **Created on:** Windows 11/ MacOS
 - **Last Update**: 09/02/21
 -  **Trello**: [Trello Project 3 groupe C ](https://trello.com/b/l22gbvK3/algosup2022project3c)

## 2. Introduction
#### 2.1: Summary
The aim of this project is to create a sound synthesizer that can be used to create  
programmable music. The ultimate aim of this project is to be able to play music from code.
#### 2.2 Glossary:
Please refer to [Functional specification](https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/Functional-Specifications.md) to find a glossary about sound synthesis.
#### 2.3: Context
The context of the project is to create a library that could be used by a developer to create, modify, listen to and save sounds used for musical purposes as well as do the same to an entire list of said sounds. 
It is really useful to learn how to produce sounds with bytes. 
#### 2.4: Requirements
You will need windows to listen to sounds, else SFML package isn't fully compatible with MacOS.
#### 2.5: Out Of Scope

 - Adding interface -> Done into a console app 
 - Web app
 - More instruments
## 3. Solution 
#### 3.1: Current Solution
The project is using **.Net 5.0** for better compatibility between OS.
The package **SFML** and **Xplot** should be added too.

Added to a usable library, we wanted to add a little bit of fun to this project and made it a console app too so you can test and have fun with the functions in a console.
If you want to use the library alone, you can open Synthe.fsproj and comment on this lign(24)

    <Compile  Include="Program.fs" />

#### 3.2: Solution Design:
User case:
![User Case](https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/UseCase.png?raw=true)
    
Console App use:

![Console App UseCase](https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/caCase.png?raw=true)
#### 3.3: Testing:
We are actually working with Test-Driven Development (TDD) so we can assure the code we produce is verified and working.
You can find the folder Synthe.test into the solution.
## 4. Further Considerations
#### 4.1: Impact on other teams:
Our program.fs can be easily adapted to your project. Everything is sorted so you can access quickly what you wanted to do. 
#### 4.2: Cost Analysis:
We have no cost on this project. We are only using open-source code or packages.
#### 4.3: Security consideration
Problems that could appear:

 - One of our two packages is corrupted from the source 
 - Our code is spagetthi code so it takes more ram and more processing.
 - The folder CreatedSounds is full of tries.

Solutions:

 - Change package 
 - Rework code to use async
 - Empty folder after x weeks/month

#### 4.4: Privacy considerations:

This project is actually open-source. Everyone can access it and use it.

#### 4.5: Accessibility considerations:
**Library Alone**: You need to be a developer.
**Console App**: Everyone should be able to use it.
#### 4.6: Risks:
We have no risks at the moment.
#### 4.7: Support considerations
We have no other way than to wait for comments to start supporting the app. However, it is likely possible that one of our team would keep working on that project.
## 5. Work
#### 5.1: Work estimates and timelines
14_01_2022: Project is done at 20%. We managed to finish "Create and Play a Basic Note" in a week.  
21_01_2022: The second part of the project is done: basic filters, envelope, and chords.  
28_01_2022: The third part of the project is done: frequency analysis and advanced filters.  
07_02_2022: The project is done, we didn't do the MP3 Compression.
#### 5.2: Prioritization

 1. Creation of 4 basic WaveForms
 2. Play Waveforms
 3. Save Waveforms
 4. Play saved Waveform
 5. ByFixedAmount
 6. Flange
 7. Reverb
 8. Echo
 9. Envelope ADSR
 10. Chords
 11. AM/FM
 12. Low Pass/High Pass 
#### 5.3 Milestones
**14/01/22:** Oscillator function: Sine, Square, Triangle, Sawtooth </br>
**21/01/22:** Part 2 - Basic Filters, Envelopes, and Chords </br>
**28/01/22:** Spectroscope </br>
## 6. End Matter
#### 6.1: Related Work
This project was inspired by [Sonic Pi ](https://sonic-pi.net/) and other live  
coding music packages.

#### 6.2: References

 - [Sonic Pi ](https://sonic-pi.net/)
 - [PlayTronica](https://synth.playtronica.com/)
 - [Midi City](https://midi.city/)

#### 6.3: Acknowledgments

-   Thanks to our teacher Robert for this project and the help he gave us.
-  The group A and D for the directionnal help.
-  Maynies who tested the app during all the process.

