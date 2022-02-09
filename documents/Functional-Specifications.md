## Functional Specifications ( 26/01/2022 )

## Synthesizer and how it works?

A **synthesizer** is an electronic musical instrument that generates audio signals. Synthesizers typically create sounds by generating waveforms. These waves may be altered by components such as filters that cut or boost frequencies, envelopes that control articulation or how notes begin and end, and low-frequency oscillators, which modulate parameters such as pitch or volume. Synthesizers are typically played with keyboards or controlled by sequencers, software, or other instruments, and can be synchronized to other equipment via MIDI.

For our project, we are in the case of software synthesizers.

## Project Target

A developer who wants to use a library to play with sound synthesis, creating music or sounds.

## Specifications

Waveforms are the starting point of synthesis and of all sound. In a synthesizer, an oscillator creates a repeated signal of a waveform. This waveform gets altered through synthesis.

#### SineWave :<br>
A sine wave is a simple periodic sound. Musical instruments or the voice produce complex periodic sounds. They have a spectrum comprising a series of harmonics. Each harmonic is a sine wave that has a frequency that is an integer multiple of the fundamental frequency.

#### TriangleWave : <br>
Also, triangular wave. An audio WAVEFORM is theoretically composed of an infinite set of odd harmonic SINE WAVEs. It is often used in SOUND SYNTHESIS where its TIMBRE is less harsh than the SQUARE WAVE because the amplitude of its upper HARMONICs falls off more rapidly.

#### SquareWave : <br>
Remember how a sine wave is only made up of one thing, the fundamental? Not the square wave. A square wave sounds richer and buzzier. It also looks different. These are both because, besides the fundamental, the square wave also contains harmonics. A harmonic is a kind of partial tone which is a whole multiple of a fundamental frequency. In a square wave, these harmonics occur in whole odd-number multiples of the fundamental frequency. The harmonics, combined with the fundamental, give this wave a square shape.

#### SawtoothWave : <br> 
Also called a saw wave, a sawtooth wave is much more jagged and, well, looks like a saw. It is the buzziest sounding of them all, sounding even harsher than a square wave, and that’s because it’s the richest in terms of harmonics. This means it can be a really great choice for when you’re working with subtractive synthesis, which is when you construct a sound by filtering out frequencies, rather than adding them on.
Think of the sound of a bow dragging across a violin. There’s a science to explain it! The friction between the bow and the string pulls the string in one direction (the saw’s ramp) until it snaps back (the saw’s flyback) and repeats, giving the slightly buzzy sound to a violin.

####  ByFixedAmount : <br>
Modify the wave’s amplitude by a fixed amount

#### Chords : <br>
A chord or grouping of notes played simultaneously can create harmony, which is when two or more notes complement one another. Chords add texture to a melody and can even provide rhythm to a song.

#### Envelope : <br>
In sound and music, an envelope describes how a sound changes. ... For example, a piano key, when struck and held, creates a near-immediate initial sound, which gradually decreases in volume to zero.

#### Overdrive : <br>
Usually, overdrive is considered a particular form of distortion caused by “pushing” an amp past its capability for producing a clean tone. Overdrive is often easily achieved in tube amps because the very nature of tube amp design is that they sound “clean” at lower volumes and distort to some extent at louder volumes.

#### Echo : <br>
Echo effects are one type of audio effect based on delaying a signal. Here, listeners perceive an audible repetition of a signal after some duration of time. Listeners perceive distinct echoes when the time delay is relatively long (greater than ~30 milliseconds).

#### Flange : <br>
Flanging is an audio effect produced by mixing two identical signals together, one signal delayed by a small and gradually changing period, usually smaller than 20 milliseconds. This produces a swept comb filter effect: peaks and notches are produced in the resulting frequency spectrum, related to each other in a linear harmonic series. Varying the time delay causes these to sweep up and down the frequency spectrum. A flanger is an effects unit that creates this effect.
Part of the output signal is usually fed back to the input (a "re-circulating delay line"), producing a resonance effect that further enhances the intensity of the peaks and troughs. The phase of the fed-back signal is sometimes inverted, producing another variation on the flanger sound.

#### Reverb : <br>
A reverberation effect, or "reverb", is an audio effect applied to a sound signal to simulate reverberation. It may be created through physical means, such as echo chambers, or through digital processing.

#### Pass Filter : <br>
A low-pass filter is a filter that passes signals with a frequency lower than a selected cutoff frequency and attenuates signals with frequencies higher than the cutoff frequency. The exact frequency response of the filter depends on the filter design. The filter is sometimes called a high-cut filter, or treble-cut filter in audio applications. A low-pass filter is the complement of a high-pass filter.<br>
A high-pass filter (HPF) is an electronic filter that passes signals with a frequency higher than a certain cutoff frequency and attenuates signals with frequencies lower than the cutoff frequency. The amount of attenuation for each frequency depends on the filter design. A high-pass filter is usually modeled as a linear time-invariant system. It is sometimes called a low-cut filter or bass-cut filter in audio engineering. High-pass filters have many uses, such as blocking DC from circuitry sensitive to non-zero average voltages or radiofrequency devices. They can also be used with a low-pass filter to produce a band-pass filter.


#### LFO : <br>
Low-frequency oscillation (LFO) is an electronic frequency that is usually below 20 Hz and creates a rhythmic pulse or sweep. This is used to modulate musical equipment, such as synthesizers, to create audio effects such as vibrato, tremolo, and phasing.

#### MP3 Compression : <br>
The WAV format is popular because it’s easy to use, but the resulting files can be very large.
This is a disadvantage for both storage and network transfer. The MP3 format became popular.
Because it can store the same sounds in a file, that’s about a factor of 10 smaller than the equivalent WAV. The format meant songs could be much more easily shared over networks and played back on small portable devices, so the format became a catalyst behind the digital
music revolution.
