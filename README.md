# ALGOSUP_2022_Project_3_C



Tu run the project as
## Console App:

```
dotnet run start
(example)
Playsong
LettreAElise 
```
```
dotnet run start
help
--> list of commands
```
```
dotnet run start
songs
--> list of songs
```
You can always add commands by creating new functions or songs and adding them to the list in **program.fs**.
To add a song, create it in **Songs.fs** and then add it in **program.fs** in:
```fs
let rec searchMusic (name: string) 
```
To add a command, create it and then add it in **program.fs** in:
```fs
let rec commands (name : string)
```
## Library:
As a library, you can use the function build in.

You can find here the four basic waves:
**Sinusoidal wave:**
```fs
let sinWave = Array.init 44100 (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate))

```
**Triangle Wave:**
```fs
let triangleWave = Array.init 44100  (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)))

```
**Square Wave:**
```fs
    let  squareWave  = Array.init 44100  (fun i -> amp * float(Math.Sign(sin((2.  * freq * Pi * float i)/sampleRate))))
```
**SawTooth Wave:**
```fs
    let  sawWave  = Array.init 44100  (fun i ->  (2.*amp/Pi)* Math.Atan(tan((Pi*float i*freq)/sampleRate)))
```
Under all of its respective functions, you will find their transformation into an array of bytes

To play a song without saving it on your computer, use the function 
```fs
 PlaySong  (song:byte[][]) 
```  
To play a file from a disk, use the function 
```fs
 PlayURL  (url:string)
```

## ByFixedAmount 
Parameter : a wave as a sin wave, an amplitude to put inside modifier.
```fs
ByFixedAmount (modifier:float) (wave:byte array) 
```

## Overdrive
Parameter : a wave, a limit your amplitude cannot exceed (flatten).
```fs
Overdrive (flatten:float) (wave: byte array) 
```

## Envelope
```fs
let Enveloppe time amplitude At De Su Re =
```
 - Attack : progressive sound augmentation.
 ```fs
 let Attack = Array.init (int (time*sampleRate*At)) (fun i -> amplitude/(time*sampleRate*At)* float i)
 ```
 - Decay : progressive sound decrease.
 ```fs
 let Decay = Array.init (int (time*sampleRate*De)) (fun i -> amplitude - (amplitude-Su*amplitude)/(time*sampleRate*De) *float i)
 ```
 - Sustain : maintain the sound.
 ```fs
let Sustain = Array.init (int (time*(sampleRate - sampleRate*Re - sampleRate*De - sampleRate*At))) (fun _ -> Su*amplitude)
```
 - Release : release to zero.
```fs
let Release = Array.init (int (time*sampleRate*Re)) (fun i -> Su*amplitude - Su*amplitude/(time*sampleRate*Re) * float i)
```
Putting them together and we have an envelope:
```fs
let amp = Array.concat [|Attack; Decay; Sustain; Release|]
```
 

## Flange
```fs  
Flange (wave:byte array)
```
## addWaves
Parameters : two waves.
```fs
addWaves (wave1: byte []) (wave2: byte []) 

```

## Reverb
Parameters : a wave, a reducer multiplicator.
```fs
 Reverb  reduc (wave: byte []) 

```

## Echo
Parameters : a wave, a reducer miltiplicator, a delay.
```fs
Echo reduc (delay:float) (wave: byte [])

```

## AM
Parameters : two different sin waves.
```fs
AM (wavep: float array) (wavem: float array) 

```

## FM
Parameter : two different sin waves.
```fs
FM (wavep: float array) (wavem: float array) 

```

## LowPassFilter
Parameter : a sin wave.
```fs
LowPassFilter (sinWave: float []) 

```

## highPassFilter
Parameter : a sin wave.
```fs
highPassFilter (sinWave: float []) 

```

To use notes, use the function associated to the note
```fs
    ADiese  (length:Length)  (octave:int)
	example: ADiese White 
```
All note's lengths have been defined into notes.fs.

You can find premade songs in songs in the Songs.fs.
```fs
let  Amogus  =  [|  // Tempo: 100

			A HalfNote 5

			C HalfNote 6

			D HalfNote 6

			DDiese HalfNote 6

			D HalfNote 6

			C HalfNote 6

			A PHalfNote 5

			Sil Silence 0

			G QuarterNote 5

			C QuarterNote 6

			A QuarterNote 5

|]
```fs
You can choose to visualise charts from waves you create using Xplot as the function below:
```fs
let  sinVisu()  =

		let  options  =

				Options

				(

				title =  "Sinusoidal Wave",

				curveType =  "function",

				vAxis = Axis(title =  "Amplitude"),

				hAxis = Axis(title =  "Frequency")

				)

sinWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show
```



Management has been done using Trello:
https://trello.com/b/l22gbvK3/algosup2022project3c


## Project Name:

**Project 3 sound synthetizer**

## Introduction:

The aim of this project is to create a sound synthesizer that can be used to create
programmable music. This project was inspired by Sonic Pi (https://sonic-pi.net/) and other live
coding music packages. The ultimate aim of this project is to be able to play music from code

## Project progress:

14_01_2022 : Project is done at 20%. We managed to finish "Create and Play a Basic Note" in a week.</br>
21_01_2022 : The second part of the project is done : basic filters, envelope and chords.</br>
28_01_2022 : The third part of the project is done : frequency analysis and advanced filters.</br>
07_02_2022 : The project is done, we didn't do the MP3 Compression.

## How to install it and run it

The project is using F#, SFML and XPlot.


## Technologies and Softwares

[![made-with-FSharp](https://img.shields.io/badge/Language%20Used-FSharp-blue)](https://fsharp.org/) 

[![made-with-Packages](https://img.shields.io/badge/Packages%20used-XPlot.GoogleCharts-brightgreen)](https://fslab.org/XPlot//chart/google-line-chart.html) [![made-with-SFML](https://img.shields.io/badge/-SFML-brightgreen)](https://www.sfml-dev.org/index-fr.php) 

[![made-with-Visual-Studio-Code](https://img.shields.io/badge/IDE-Visual%20Studio-blueviolet)](https://code.visualstudio.com) 

Functional-Specifications : https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/Functional-Specifications.md </br>
Technical-Specifications : https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/Technical-Specifications.md </br>
Software-Architecture : https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/software_architecture.pdf</br>

## Issues and how to correct them

SFML isn't working well on mac.</br>
8D-solving : </br>
SFML : https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/8D_SFML.pdf </br>
Documents : https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/8D_Documents.pdf </br>
Spectroscope :https://github.com/KarineVinette/ALGOSUP_2022_Project_3_C/blob/main/documents/8D_spectroscope.pdf




