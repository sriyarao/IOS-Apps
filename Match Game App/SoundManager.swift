//
//  SoundManager.swift
//  Match App
//
//  Created by Sriya Bahunuthula on 7/27/18.
//  Copyright © 2018 Sriya Bahunuthula. All rights reserved.
//

import Foundation
import AVFoundation

class SoundManager
{
    static var audioPlayer:AVAudioPlayer?
    
    enum SoundEffect
    {
        case flip
        case shuffle
        case match
        case nomatch
    }
    
    static func playSound(_ effect:SoundEffect)
    {
        var soundFilename = ""
        
        switch effect
        {
            
        case .flip:
            soundFilename = "cardflip"
            
        case .shuffle:
            soundFilename = "shuffle"
            
        case .match:
            soundFilename = "dingcorrect"
            
        case .nomatch:
            soundFilename = "dingwrong"
        }
        let bundlePath = Bundle.main.path(forResource: soundFilename, ofType: "wav")
        guard bundlePath != nil else
        {
            print("Could not find sound file \(soundFilename) in the bundle")
            return
        }
        
        let soundURL = URL(fileURLWithPath: bundlePath!)
        
        do
        {
            audioPlayer = try AVAudioPlayer(contentsOf: soundURL)
            audioPlayer?.play()
        }
        catch
        {
            print("Could not create the object for the sound file \(soundFilename)")
        }
        
        
    }
}

