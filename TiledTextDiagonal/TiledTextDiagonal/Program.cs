//*******************************************************************
//       ByteScout Watermarking SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using Bytescout.Watermarking;
using Bytescout.Watermarking.Presets;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Watermarker instance
            Watermarker waterMarker = new Watermarker();

            // Initialize library
            waterMarker.InitLibrary("demo", "demo");

            // Set input file name
            string inputFilePath = "my_sample_image.jpg";
            // Set output file title
            string outputFilePath = "my_sample_output.jpg";

            // Add image to apply watermarks to
            waterMarker.AddInputFile(inputFilePath, outputFilePath);

            // Create new watermark
            TiledTextDiagonal preset = new TiledTextDiagonal();

            // Set text
            preset.Text = "Sample watermark text";

            // Set font size
            preset.Font.Style = FontStyle.Bold;
            preset.Font.Size = 3;

            preset.Transparency = 15;

            // Add watermark to watermarker
            waterMarker.AddWatermark(preset);

            // Set output directory
            waterMarker.OutputOptions.OutputDirectory = ".";

            // Apply watermarks
            waterMarker.Execute();

            // open generated image file in default image viewer installed in Windows
            Process.Start(outputFilePath);
        }
    }
}
