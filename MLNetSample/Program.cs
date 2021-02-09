using MLNETSampleML.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLNETSample
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = new ModelInput();
            input.Col0 = @"Wow... Loved this place.";
            ModelOutput predictionResult = ConsumeModel.Predict(input);
            Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");
            
            Console.WriteLine($"\n\nPredicted Col1 value {predictionResult.Prediction} \nPredicted Col1 scores: [{String.Join(",", predictionResult.Score)}]\n\n");
           
            Console.ReadKey();
        }
    }
}
