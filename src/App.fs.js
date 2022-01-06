import { chunkBySize, append, collect, singleton, enumerateWhile, enumerateUsing, empty, mapIndexed, unfold, choose, toList, cache, sum, delay, maxBy, map, toArray, initialize } from "./.fable/fable-library.3.2.9/Seq.js";
import { round, min, max, getEnumerator, comparePrimitives } from "./.fable/fable-library.3.2.9/Util.js";
import { rangeDouble } from "./.fable/fable-library.3.2.9/Range.js";
import { ofArray, map as map_1, isEmpty } from "./.fable/fable-library.3.2.9/List.js";
import { FSharpRef } from "./.fable/fable-library.3.2.9/Types.js";
import { average } from "./.fable/fable-library.3.2.9/Array.js";
import { toBase64String } from "./.fable/fable-library.3.2.9/String.js";

export const MiscConsts_SampleRate = 44100;

export const MiscConsts_A440 = 440;

const Waves_semitone = Math.pow(2, 1 / 12);

const Waves_middleC = (MiscConsts_A440 * Math.pow(Waves_semitone, 3)) / 2;

export function Waves_frequencyOfNote(note, octave) {
    return (Waves_middleC * Math.pow(Waves_semitone, note)) * Math.pow(2, octave - 4);
}

export function Waves_phaseAngleIncrementOfFrequency(frequency) {
    return frequency / MiscConsts_SampleRate;
}

export const Time_beatsPerSemibreve = 4;

function Time_beatsPerSecond(bmp) {
    return 60 / bmp;
}

function Time_samplesPerBar(bmp) {
    return (MiscConsts_SampleRate * Time_beatsPerSecond(bmp)) * Time_beatsPerSemibreve;
}

export const Time_longa = 4;

export const Time_breve = 2;

export const Time_semibreve = 1;

export const Time_minim = 1 / 2;

export const Time_crotchet = 1 / 4;

export const Time_quaver = 1 / 8;

export const Time_semiquaver = 1 / 16;

export const Time_demisemiquaver = 1 / 32;

export function Time_noteValue(bmp, note) {
    return ~(~(Time_samplesPerBar(bmp) * note));
}

export function Creation_makeSilence(length) {
    return initialize(length, (_arg1) => 0);
}

export function Creation_makeWave(waveFunc, length, frequency) {
    const phaseAngleIncrement = Waves_phaseAngleIncrementOfFrequency(frequency);
    return initialize(length, (x) => {
        const phaseAngle = phaseAngleIncrement * x;
        const x_1 = Math.floor(phaseAngle);
        return waveFunc(phaseAngle - x_1);
    });
}

export function Creation_makeNote(waveFunc, length, note, octave) {
    const frequency = Waves_frequencyOfNote(note, octave);
    return Creation_makeWave(waveFunc, length, frequency);
}

export function Creation_sine(phaseAngle) {
    return Math.sin((2 * 3.141592653589793) * phaseAngle);
}

export function Creation_square(phaseAngle) {
    if (phaseAngle < 0.5) {
        return -1;
    }
    else {
        return 1;
    }
}

export function Creation_triangle(phaseAngle) {
    if (phaseAngle < 0.5) {
        return 2 * phaseAngle;
    }
    else {
        return 1 - (2 * phaseAngle);
    }
}

export function Creation_sawtooth(phaseAngle) {
    return -1 + phaseAngle;
}

export function Creation_makeCord(waveDefs) {
    const wavesMatrix = toArray(map((source) => toArray(source), waveDefs));
    const waveScaleFactor = 1 / wavesMatrix.length;
    const maxLength = maxBy((x) => x.length, wavesMatrix, {
        Compare: (x_1, y) => comparePrimitives(x_1, y),
    });
    const getValues = (i) => delay(() => map((x_2) => ((i > wavesMatrix[x_2].length) ? 0 : wavesMatrix[x_2][i]), rangeDouble(0, 1, wavesMatrix.length - 1)));
    return delay(() => map((x_3) => (sum(getValues(x_3), {
        GetZero: () => 0,
        Add: (x_4, y_1) => (x_4 + y_1),
    }) * waveScaleFactor), rangeDouble(0, 1, maxLength.length - 1)));
}

export function Creation_combine(waveDefs) {
    const enumerators = cache(map((x) => getEnumerator(x), waveDefs));
    const loop = () => {
        const values = toList(choose((x_1) => {
            if (x_1["System.Collections.IEnumerator.MoveNext"]()) {
                return x_1["System.Collections.Generic.IEnumerator`1.get_Current"]();
            }
            else {
                return void 0;
            }
        }, enumerators));
        if (isEmpty(values)) {
            return void 0;
        }
        else {
            const x_2 = values;
            return [sum(x_2, {
                GetZero: () => 0,
                Add: (x_3, y) => (x_3 + y),
            }), void 0];
        }
    };
    return unfold(loop, void 0);
}

export function Transformation_scaleHeight(multiplier, waveDef) {
    return map((x) => (x * multiplier), waveDef);
}

const Transformation_rnd = {};

export function Transformation_addNoise(multiplier, waveDef) {
    return map((x) => {
        const rndValue = 0.5 - Math.random();
        return x + (rndValue * multiplier);
    }, waveDef);
}

export function Transformation_flatten(limit, waveDef) {
    return map((x) => max((x_2, y_1) => comparePrimitives(x_2, y_1), -limit, min((x_1, y) => comparePrimitives(x_1, y), x, limit)), waveDef);
}

export function Transformation_tapper(startMultiplier, endMultiplier, waveDef) {
    const waveVector = toArray(waveDef);
    const step = (endMultiplier - startMultiplier) / waveVector.length;
    return mapIndexed((i, x) => (x * (startMultiplier + (step * i))), waveVector);
}

function Transformation_gaussian(a, b, c, x) {
    return Math.pow(a * 2.718281828459045, -(Math.pow(x - b, 2) / Math.pow(c * 2, 2)));
}

export function Transformation_gaussianTapper(length, waveDef) {
    const waveVector = toArray(waveDef);
    const step = 1 / waveVector.length;
    return mapIndexed((i, x) => (x * Transformation_gaussian(1, 0, length, step * i)), waveVector);
}

export function Transformation_revGaussianTapper(length, waveDef) {
    const waveVector = toArray(waveDef);
    const len = waveVector.length;
    const step = 1 / len;
    return mapIndexed((i, x) => (x * Transformation_gaussian(1, 0, length, step * (len - i))), waveVector);
}

export function Transformation_doubleGaussianTapper(startLength, endLength, waveDef) {
    const waveVector = toArray(waveDef);
    const len = waveVector.length;
    const step = 1 / len;
    return mapIndexed((i, x) => ((x * Transformation_gaussian(1, 0, startLength, step * (len - i))) * Transformation_gaussian(1, 0, endLength, step * i)), waveVector);
}

function NoteSequencer_safeTake(wanted, source) {
    if (wanted === 0) {
        return empty();
    }
    else {
        return delay(() => enumerateUsing(getEnumerator(source), (e) => {
            const count = new FSharpRef(0);
            return enumerateWhile(() => (e["System.Collections.IEnumerator.MoveNext"]() ? (count.contents < wanted) : false), delay(() => {
                void(count.contents++);
                return singleton(e["System.Collections.Generic.IEnumerator`1.get_Current"]());
            }));
        }));
    }
}

export function NoteSequencer_sequence(noteTable, notes) {
    return delay(() => collect((matchValue) => {
        const length = matchValue[1] | 0;
        const cordNotes = matchValue[0];
        const notes_1 = map((tupledArg) => {
            const note = tupledArg[0] | 0;
            const octave = tupledArg[1] | 0;
            return noteTable(note, octave);
        }, cordNotes);
        return NoteSequencer_safeTake(length, Creation_combine(notes_1));
    }, notes));
}

export const WaveFormat_sampleRate = 44100;

export const WaveFormat_channels = 1;

export function WaveFormat_bytesOfInt16(i) {
    return map_1((shift) => {
        const value = ((i >> shift) & 255) | 0;
        return value & 0xFF;
    }, ofArray([0, 8]));
}

export function WaveFormat_bytesOfInt(i) {
    return map_1((shift) => {
        const value = ((i >> shift) & 255) | 0;
        return value & 0xFF;
    }, ofArray([0, 8, 16, 24]));
}

export function WaveFormat_wavOfBuffer(buffer) {
    const sixteenBitLength = (2 * buffer.length) | 0;
    return toArray(delay(() => append(map((value) => value.charCodeAt(0), "RIFF".split("")), delay(() => append(WaveFormat_bytesOfInt(sixteenBitLength + 15), delay(() => append(map((value_1) => value_1.charCodeAt(0), "WAVE".split("")), delay(() => append(map((value_2) => value_2.charCodeAt(0), "fmt ".split("")), delay(() => append(singleton(18), delay(() => append(singleton(0), delay(() => append(singleton(0), delay(() => append(singleton(0), delay(() => append(singleton(1), delay(() => append(singleton(0), delay(() => append(singleton(WaveFormat_channels & 0xFF), delay(() => append(singleton(0), delay(() => append(WaveFormat_bytesOfInt(WaveFormat_sampleRate), delay(() => append(WaveFormat_bytesOfInt((2 * WaveFormat_channels) * WaveFormat_sampleRate), delay(() => append(singleton(4), delay(() => append(singleton(0), delay(() => append(singleton(16), delay(() => append(singleton(0), delay(() => append(singleton(0), delay(() => append(singleton(0), delay(() => append(map((value_4) => value_4.charCodeAt(0), "data".split("")), delay(() => append(WaveFormat_bytesOfInt(sixteenBitLength), delay(() => collect((i) => {
        let value_5;
        const tmp = buffer[i];
        return (tmp >= 1) ? append(singleton(255), delay(() => singleton(255))) : ((tmp <= -1) ? append(singleton(0), delay(() => singleton(0))) : WaveFormat_bytesOfInt16((value_5 = round(tmp * 32767), (value_5 + 0x8000 & 0xFFFF) - 0x8000)));
    }, toList(rangeDouble(0, 1, buffer.length - 1)))))))))))))))))))))))))))))))))))))))))))))))));
}

export const Svg_svg = document.getElementById("svg");

export function Svg_displayWave(points) {
    const margin = 10;
    const lineSpacing = 1;
    const lineWidth = 1;
    const length = (~(~(Svg_svg.clientWidth / lineSpacing))) | 0;
    const midPoint = Svg_svg.clientHeight / 2;
    const maxLine = midPoint - margin;
    const rnd = {};
    const chunkSize = (~(~(points.length / length))) | 0;
    const samples = toArray(map((array) => average(array, {
        GetZero: () => 0,
        Add: (x_2, y) => (x_2 + y),
        DivideByInt: (x_1, i) => (x_1 / i),
    }), chunkBySize(chunkSize, map((x) => Math.abs(x), points))));
    const svgns = "http://www.w3.org/2000/svg";
    for (let i_1 = 1; i_1 <= length; i_1++) {
        const size = samples[i_1] * maxLine;
        const y1 = midPoint - size;
        const y2 = midPoint + size;
        const line = document.createElementNS(svgns, "line");
        const x_3 = i_1 * lineSpacing;
        line.setAttributeNS(null, "x1", x_3.toString());
        line.setAttributeNS(null, "y1", y1.toString());
        line.setAttributeNS(null, "x2", x_3.toString());
        line.setAttributeNS(null, "y2", y2.toString());
        line.setAttributeNS(null, "stroke-width", lineWidth.toString());
        line.setAttributeNS(null, "stroke", "#000000");
        void document.getElementById("svg").appendChild(line);
    }
}

export const Html_audio = document.getElementsByTagName("audio")[0];

export function Html_loadSound(soundSequence) {
    const getBaseWav64 = (sound) => {
        const wav = WaveFormat_wavOfBuffer(toArray(sound));
        return toBase64String(wav);
    };
    const soundBuffer = toArray(soundSequence);
    const wavBase64 = getBaseWav64(soundBuffer);
    Html_audio.src = ("data:audio/wav;base64," + wavBase64);
    Svg_displayWave(soundBuffer);
}

export const bpm = 90;

export const crotchet = Time_noteValue(bpm, Time_crotchet);

export const quaver = Time_noteValue(bpm, Time_quaver);

export function makeNote(time, note) {
    return Transformation_gaussianTapper(0.1, Creation_makeNote((phaseAngle) => Creation_sine(phaseAngle), time, note, 4));
}

export const baaBaaBlackSheepChorus = delay(() => append(makeNote(crotchet, 0), delay(() => append(makeNote(crotchet, 0), delay(() => append(makeNote(crotchet, 7), delay(() => append(makeNote(crotchet, 7), delay(() => append(makeNote(crotchet, 9), delay(() => append(makeNote(crotchet, 9), delay(() => append(makeNote(quaver, 9), delay(() => append(makeNote(quaver, 9), delay(() => append(makeNote(crotchet, 7), delay(() => append(makeNote(crotchet, 5), delay(() => append(makeNote(crotchet, 5), delay(() => append(makeNote(crotchet, 4), delay(() => append(makeNote(crotchet, 4), delay(() => append(makeNote(crotchet, 2), delay(() => append(makeNote(crotchet, 2), delay(() => makeNote(crotchet, 0))))))))))))))))))))))))))))))));

Html_loadSound(baaBaaBlackSheepChorus);

