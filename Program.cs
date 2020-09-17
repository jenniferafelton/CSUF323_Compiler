﻿using System;

namespace JenPile {
    class Program {
        static void Main(string[] args) {
            string fileToCompile = null;

            for(int i = 0; i < args.Length; i++) {
                if((args[i] == "-c") && (i + 1 < args.Length) && (args[i + 1] != null)) {
                    // Example: CSUF323_Compiler.exe -c helloworld.jen 
                    fileToCompile = args[i + 1];
                }
            }

            InputCollector input = new InputCollector();
            if(fileToCompile != null) {
                input.ReadInFile(fileToCompile);
            } else {
                input.ReadInUserInput();
            }
        }        

      
        //TODO: FSM

        //TODO: Outputs
    }
}
