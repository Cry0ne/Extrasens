using System;
using System.Collections.Generic;

namespace Extrasens.Data
{
    public class Psychic
    {

        private readonly Random  rand= new Random();

        private int predictNumber;
        private int psychicRaiting = 100;       
        private string responseStatus;

        public int PredictNumber { get => predictNumber; set => predictNumber = value; }
        public int PsychicRaiting { get => psychicRaiting; set => psychicRaiting = value; }
        public string ResponseStatus { get => responseStatus; set => responseStatus = value; }

        public void PredictionNumber()
        {
            predictNumber = rand.Next(10, 99);
        }

        public static List<Psychic> Objects = new List<Psychic>();

        public Psychic()
        {
            Objects.Add(this);
        }



    }
}
