﻿using FlightControl.Exceptions;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace FlightControl
{
    public class Flight
    {
        private List<Stage> Stages;
        public bool IsCompleted;
        public Stage this[int index]
        {
            get
            {
                return Stages[index];
            }
        }
        public Flight(List<Stage> stages)
        {
            if (stages.Count == 0)
                throw new NotEnoughElementsException("Flight cannot be created, because stages' list is empty.");

            Stages = new List<Stage>(stages.Count);
            for (int i = 0; i < stages.Count; ++i)
                Stages.Add(new Stage(stages[i]));

            IsCompleted = false;
        }
        public Flight(Flight o) : this(o.Stages)
        {
        }
        public void AddStage(Point destination, double velocity, double altitude)
        {
            Line line = new Line(Stages[Stages.Count - 1].Track.End.X, Stages[Stages.Count - 1].Track.End.Y,
                destination.X, destination.Y);
            Stages.Add(new Stage(line, velocity, altitude));
        }
        public void RemoveStage(int index)
        {
            if (index >= 0 && index < Stages.Count)
            {
                Stages.RemoveAt(index);
                if (Stages.Count == 0)
                    IsCompleted = true;
            }
        }
        public void Draw(WriteableBitmap bitmap, int color)
        {
            foreach (var stage in Stages)
                stage.Draw(bitmap, color);
        }
    }
}